namespace DigitalStudentCard.Core.Constants
{
    public static class ApiConstants
    {

        public static string ApiUrl = $"{Scheme}://{BaseUrl}:{ApiPort}";
        // public static string ApiUrl = $"{Scheme}://{BaseUrl}:{ImagesPort}/{ImagesPrefix}";

        public const string Scheme = "http"; // or https
        public const string BaseUrl = "192.168.0.129";
        public const string ApiPort = "5000"; // 5000 for http, 5001 for https
        // public const string ImagesPort = "5002"; 
        public const string ApiPrefix = "api";
        // public const string ImagesPrefix = "images/";

        // Endpoints
        public static string StudentsEndpointPath = $"{ApiPrefix}/students";
        public static string LectorsEndpointPath = $"{ApiPrefix}/lectors";
        public static string PresencesEndpointPath = $"{ApiPrefix}/presences";
        public static string AuthenticateEndpointPath = $"{ApiPrefix}/authentication/authenticate";
        // public static string RegisterEndpointPath = $"{ApiPrefix}/authentication/register";
    }
}


