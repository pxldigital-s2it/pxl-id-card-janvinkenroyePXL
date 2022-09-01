namespace DigitalStudentCard.Core.Constants
{
    public static class ApiConstants
    {

        public static string ApiUrl = $"{Scheme}://{BaseUrl}:{ApiPort}/{ApiPrefix}";
        // public static string ApiUrl = $"{Scheme}://{BaseUrl}:{ImagesPort}/{ImagesPrefix}";

        public const string Scheme = "http"; // or https
        public const string BaseUrl = "localhost";
        public const string ApiPort = "5000"; // 5000 for http, 5001 for https
        // public const string ImagesPort = "5002"; 
        public const string ApiPrefix = "api/";
        // public const string ImagesPrefix = "images/";

        // Endpoints
        public static string StudentsEndpointPath = "/students";
        public static string LectorsEndpointPath = "/lectors";
        public static string PresencesEndpointPath = "/presences";
        public static string AuthenticateEndpointPath = "/authentication/authenticate";
        // public static string RegisterEndpointPath = "/authentication/register";
    }
}


