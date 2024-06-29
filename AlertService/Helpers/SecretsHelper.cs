namespace AlertService.Helpers
{
    public class SecretsHelper
    {
        public static string GetDatabaseConnectionString(WebApplicationBuilder builder)
        {
            var host = builder.Configuration["ConnectionStrings:IoTManagementDeviceAlertDB:Host"];
            var port = builder.Configuration["ConnectionStrings:IoTManagementDeviceAlertDB:Port"];
            var dataBase = builder.Configuration["ConnectionStrings:IoTManagementDeviceAlertDB:Database"];
            var userName = builder.Configuration["ConnectionStrings:IoTManagementDeviceAlertDB:Username"];
            var password = builder.Configuration["ConnectionStrings:IoTManagementDeviceAlertDB:Password"];

            return $"Server={host};Port={port};Database={dataBase};Username={userName};Password={password};";
        }
    }
}