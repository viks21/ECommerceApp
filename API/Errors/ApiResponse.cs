namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultessageForStatusCode(StatusCode);
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }

        private string GetDefaultessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request is made",
                401 => "You are not  authorized",
                404 => "Resource found , it was not",
                500 => "Errors are the path to the dark side. Error leds to anger. Anger leads to hate.Hate leads to career change.",
                _ => null
            };

        }
    }
}