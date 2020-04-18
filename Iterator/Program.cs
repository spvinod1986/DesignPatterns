using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhotoBook = new PhotoBook();
            myPhotoBook.Push(new Photo
            {
                PhotoName = "AtlantaPhoto001",
                PhotoSizeInKb = 112,
                PhotoDateTimeStamp = DateTime.Parse("01/02/2018")
            });
            myPhotoBook.Push(new Photo
            {
                PhotoName = "ChicagoPhoto003",
                PhotoSizeInKb = 500,
                PhotoDateTimeStamp = DateTime.Parse("03/05/2016")

            });
            myPhotoBook.Push(new Photo
            {
                PhotoName = "FloridaPhoto002",
                PhotoSizeInKb = 256,
                PhotoDateTimeStamp = DateTime.Parse("02/02/2017")

            });

            var iterator = myPhotoBook.GetIterator(true);
            System.Console.WriteLine("Iterate Photo by Size");
            while (iterator.HasNext())
            {
                var photo = iterator.Current();
                System.Console.WriteLine($"Photo {photo.PhotoName} of size {photo.PhotoSizeInKb}");
                iterator.Next();
            }

            iterator = myPhotoBook.GetIterator(false);
            System.Console.WriteLine("Iterate Photo by Date");
            while (iterator.HasNext())
            {
                var photo = iterator.Current();
                System.Console.WriteLine($"Photo {photo.PhotoName} taken on date {photo.PhotoDateTimeStamp}");
                iterator.Next();
            }
        }
    }
}
