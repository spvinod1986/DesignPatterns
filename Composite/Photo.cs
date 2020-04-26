namespace Composite
{
    public class Photo : IComponent
    {
        private readonly string _photoName;
        public Photo(string photoName)
        {
            _photoName = photoName;
        }
        public void AddTag(string tagName)
        {
            System.Console.WriteLine($"Tag {tagName} added to Photo {_photoName}");
        }

        public void Render()
        {
            System.Console.WriteLine($"Rendering Photo {_photoName}");
        }
    }
}