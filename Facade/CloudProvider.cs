namespace Facade
{
    public class CloudProvider
    {
        private string _url;
        public CloudConnection Connect(string url)
        {
            _url = url;
            System.Console.WriteLine($"Connecting to Cloud server {url}");
            return new CloudConnection(url);
        }

        public BlobContainer GetContainer(string authToken, string containerName)
        {
            System.Console.WriteLine($"Accessing container {containerName}");
            return new BlobContainer(authToken, containerName);
        }

        public string SaveBlob(BlobContainer container, string content)
        {
            System.Console.WriteLine($"Saving the blob {content} in the Container");
            return _url + content;
        }
    }
}