namespace DeepIn.EventBus.RabbitMQ
{
    public class RabbitMQConfiguration
    {
        public static string ConfigurationKey = "RabbitMQ";
        public string HostName { get; set; }
        public string VirtualHost { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
    }
}