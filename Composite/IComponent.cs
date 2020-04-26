namespace Composite
{
    public interface IComponent
    {
        void Render();
        void AddTag(string tagName);
    }
}