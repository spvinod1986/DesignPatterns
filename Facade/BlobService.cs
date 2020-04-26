namespace Facade
{
    public class BlobService
    {
        public void Save(string url, string containerName, string blobContent)
        {
            var cloudProvider = new CloudProvider();
            var connection = cloudProvider.Connect(url);
            var token = connection.GetAuthToken();
            var container = cloudProvider.GetContainer(token, containerName);
            var blobPath = cloudProvider.SaveBlob(container, blobContent);
            System.Console.WriteLine($"Blob saved in {blobPath}");
        }
    }
}