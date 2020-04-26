using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var album1 = new Album("Album1");
            album1.AddElement(new Photo("Photo1.jpg"));
            album1.AddElement(new Photo("Photo2.jpg"));

            var album2 = new Album("Album2");
            album2.AddElement(new Photo("Photo3.jpg"));
            album2.AddElement(new Photo("Photo4.jpg"));
            album2.AddElement(new Photo("Photo5.jpg"));

            var album3 = new Album("Album3");
            album3.AddElement(album1);
            album3.AddElement(album2);

            album3.Render();
            album3.AddTag("Vacation");
        }
    }
}
