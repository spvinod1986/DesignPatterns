using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var blobService = new BlobService();
            blobService.Save("https://oneFrive/abc/", "ProjectDocuments", "NewDocument1");
        }
    }
}
