namespace Tutorial.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int Id { get; internal set; }
        public string Message { get; internal set; }
        public int Count { get; internal set; }
    }
}