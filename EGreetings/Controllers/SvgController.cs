using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using static System.Net.WebRequestMethods;

namespace Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SvgController : ControllerBase
    {
        private readonly string storageConnectionString;

        public SvgController(IConfiguration configuration)
        {
            storageConnectionString = configuration["AzureStorage:ConnectionString"];
        }

        [HttpPost("save")]
        public async Task<IActionResult> SaveSvg([FromBody] SvgData svgData)
        {
            // Kiểm tra xem dữ liệu SVG có hợp lệ không
            if (svgData == null || string.IsNullOrEmpty(svgData.EditedSvg))
            {
                return BadRequest("SVG content cannot be empty.");
            }

            string editedBlobName = $"UserID_{DateTime.UtcNow.Ticks}.svg";

            try
            {
                BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("design-template-svg");

                await containerClient.CreateIfNotExistsAsync();

                // Lưu SVG đã chỉnh sửa
                await UploadSvgAsync(containerClient, editedBlobName, svgData.EditedSvg);

                //return Ok(new { EditedUrl = $"{containerClient.Uri}/{editedBlobName}" });
                return Ok(new { EditedUrl = $"{"https://egreetings.blob.core.windows.net/design-template-svg"}/{editedBlobName}" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error uploading SVG: {ex.Message}");
            }
        }

        [HttpPost("save-video")]
        public async Task<IActionResult> SaveVideo(IFormFile video)
        {
            // Kiểm tra xem tệp video có hợp lệ không
            if (video == null || video.Length == 0)
            {
                return BadRequest("Video không hợp lệ.");
            }

            string videoBlobName = $"VideoID_{DateTime.UtcNow.Ticks}.mp4"; // Đổi đuôi nếu cần

            try
            {
                BlobServiceClient blobServiceClient = new BlobServiceClient(storageConnectionString);
                BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient("design-template-video");

                await containerClient.CreateIfNotExistsAsync();

                // Lưu video
                await UploadVideoAsync(containerClient, videoBlobName, video);

                return Ok(new { EditedUrl = $"{"https://egreetings.blob.core.windows.net/design-template-svg"}/{videoBlobName}" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Lỗi khi tải video: {ex.Message}");
            }
        }

        private async Task UploadVideoAsync(BlobContainerClient containerClient, string blobName, IFormFile video)
        {
            BlobClient blobClient = containerClient.GetBlobClient(blobName);
            using (var stream = video.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, true);
            }
        }

        private async Task UploadSvgAsync(BlobContainerClient containerClient, string blobName, string svgContent)
        {
            BlobClient blobClient = containerClient.GetBlobClient(blobName);
            using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(svgContent)))
            {
                await blobClient.UploadAsync(stream, true);
            }
        }

        public class SvgData
        {
            public string EditedSvg { get; set; } // Chỉ giữ lại trường EditedSvg
        }


    }

}