namespace EGreetings.Models.ViewModelAccount
{
    public class Email
    {
        public int Id { get; set; }               // ID của email
        public string ToEmail { get; set; }       // Địa chỉ email người nhận
        public string? Subject { get; set; }       // Tiêu đề email
        public string? Body { get; set; }          // Nội dung email
        public string? SvgUrl { get; set; }
             public string? VideoUrl { get; set; }
        public DateTime? SendDateTime { get; set; } // Thời gian gửi email
        public bool IsSent { get; set; }          // Trạng thái email đã được gửi chưa
    }

}
