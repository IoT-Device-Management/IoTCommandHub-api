namespace IotCommandHubEFLibrary.Entities
{
    public class Alert
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime SentAt { get; set; }
    }
}