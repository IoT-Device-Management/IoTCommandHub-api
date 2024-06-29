namespace IotCommandHubEFLibrary.Entities
{
    public class Telemetry
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Data { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}