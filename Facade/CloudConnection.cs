namespace Facade
{
    public class CloudConnection
    {
        public string Url { get; private set; }
        public CloudConnection(string url)
        {
            Url = url;
        }

        public string GetAuthToken()
        {
            System.Console.WriteLine("Generating Auth Token");
            return "Authenticated";
        }
    }
}