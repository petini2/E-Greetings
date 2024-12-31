using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json.Nodes;

namespace EGreetings_Project.Controllers
{
    public class PaypalController : Controller
    {

        private string _ClientId { get; set; } = "";
        private string _Secret { get; set; } = "";
        private string _BaseUrl { get; set; } = "";


        public PaypalController(IConfiguration configuration)
        {
            _ClientId = configuration["PaypalSandbox:ClientId"] ?? "";
            _Secret = configuration["PaypalSandbox:Secret"] ?? "";
            _BaseUrl = configuration["PaypalSandbox:BaseUrl"] ?? "";
        }

        public IActionResult Index()
        {
            ViewBag.ClientId = _ClientId;
            return View();
        }



        private async Task<string> GetAccessToken()
        {
            string accessToken = "";

            string url = $"{_BaseUrl}/v1/oauth2/token";
            using (var client = new HttpClient())
            {
                string credentials64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(_ClientId + ":" + _Secret));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials64);
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                requestMessage.Content = new StringContent("grant_type=client_credentials", null, "application/x-www-form-urlencoded");
                var httpResponse = await client.SendAsync(requestMessage);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var response = await httpResponse.Content.ReadAsStringAsync();
                    var jsonResponse = JsonNode.Parse(response);
                    if (jsonResponse != null)
                    {
                        accessToken = jsonResponse["access_token"]?.ToString() ?? "";
                    }
                }
            }


            return accessToken;
        }


        [HttpPost]
        public async Task<JsonResult> CreateOrder([FromBody] JsonObject data)
        {
            var amount = data["amount"]?.ToString();
            if (amount == null)
            {
                return new JsonResult(new { Id = "" });
            }

            var orderRequest = new JsonObject
            {
                ["intent"] = "CAPTURE",
                ["purchase_units"] = new JsonArray {
                  new JsonObject {
                      ["amount"] = new JsonObject {
                        ["currency_code"] = "USD",
                        ["value"] = amount
              }
            }
          }
            };

            string accessToken = await GetAccessToken();
            string url = $"{_BaseUrl}/v2/checkout/orders";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                requestMessage.Content = new StringContent(orderRequest.ToString(), null, "application/json");
                var httpResponse = await client.SendAsync(requestMessage);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var response = await httpResponse.Content.ReadAsStringAsync();
                    var jsonResponse = JsonNode.Parse(response);
                    if (jsonResponse != null)
                    {
                        // Console.WriteLine("[CREATE] jsonResponse: " + jsonResponse);
                        string orderId = jsonResponse["id"]?.ToString() ?? "";
                        return new JsonResult(new { Id = orderId });
                    }
                }
            }


            return new JsonResult(new { Id = "" });
        }






        [HttpPost]
        public async Task<JsonResult> CaptureOrder([FromBody] JsonObject data)
        {
            var orderId = data["orderID"]?.ToString();

            if (orderId == null)
            {
                return new JsonResult("error");
            }

            string accessToken = await GetAccessToken();
            string url = $"{_BaseUrl}/v2/checkout/orders/{orderId}/capture";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
                var requestMessage = new HttpRequestMessage(HttpMethod.Post, url);
                requestMessage.Content = new StringContent("", null, "application/json");
                var httpResponse = await client.SendAsync(requestMessage);

                if (httpResponse.IsSuccessStatusCode)
                {
                    var response = await httpResponse.Content.ReadAsStringAsync();
                    var jsonResponse = JsonNode.Parse(response);
                    if (jsonResponse != null)
                    {
                        string orderStatus = jsonResponse["status"]?.ToString() ?? "";
                        var paymentStatus = jsonResponse["purchase_units"]?[0]?["payments"]?["captures"]?[0]?["status"]?.ToString();
                        // Console.WriteLine("[CAPTURE] jsonResponse: " + jsonResponse);

                        if (orderStatus == "COMPLETED")
                        {
                            return new JsonResult("success");
                        }
                    }
                }
            }

            return new JsonResult("error");
        }





    }

}
