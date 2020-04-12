using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // User browses and opens a photo or takes a photo
            var photo = new Photo
            {
                Filter = Filter.Original,
                Brightness = 50,
                Contrast = 50,
                Sharpness = 50,
                Color = 50
            };

            // User opens the photo in app (for example - instagram) editor
            var editor = new PhotoEditorAdapter(photo);
            System.Console.WriteLine($"Filter in original Photo is : {photo.Filter}");

            photo = editor.ChangeFilter(Filter.BlackandWhite);
            System.Console.WriteLine($"User applied first filter : {photo.Filter}");

            photo = editor.ChangeFilter(Filter.Cool);
            System.Console.WriteLine($"User applied second filter : {photo.Filter}");

            System.Console.WriteLine($"User is not happy with both the filters");

            photo = editor.Undo();
            System.Console.WriteLine($"User did the first undo and the filter changed to : {photo.Filter}");

            photo = editor.Undo();
            System.Console.WriteLine($"User did the second undo and the filter changed to : {photo.Filter}");
        }
    }
}
