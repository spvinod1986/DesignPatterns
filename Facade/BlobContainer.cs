namespace Facade
{
    public class BlobContainer
    {
        private readonly string _authToken;
        private readonly string _containerName;
        public BlobContainer(string authToken, string containerName)
        {
            _authToken = authToken;
            _containerName = containerName;
        }
    }
}