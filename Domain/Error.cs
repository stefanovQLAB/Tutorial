namespace Domain
{
    public class Error
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public DateTime? DateOfError { get; set; }
    }
    public class Developer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Error> Errors { get; set; }
    }
}