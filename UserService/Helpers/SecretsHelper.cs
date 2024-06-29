namespace UserService.Helpers
{
    public class SecretsHelper
    {
        public static string GetDatabaseConnectionString(WebApplicationBuilder builder)
        {
            var host = builder.Configuration["ConnectionStrings:IoTManagementDeviceUserDB:Host"];
            var port = builder.Configuration["ConnectionStrings:IoTManagementDeviceUserDB:Port"];
            var dataBase = builder.Configuration["ConnectionStrings:IoTManagementDeviceUserDB:Database"];
            var userName = builder.Configuration["ConnectionStrings:IoTManagementDeviceUserDB:Username"];
            var password = builder.Configuration["ConnectionStrings:IoTManagementDeviceUserDB:Password"];

            return $"Server={host};Port={port};Database={dataBase};Username={userName};Password={password};";
        }
    }
}