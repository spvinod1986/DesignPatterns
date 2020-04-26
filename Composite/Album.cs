using System.Collections.Generic;

namespace Composite
{
    public class Album : IComponent
    {
        private readonly List<IComponent> _components;
        private readonly string _albumName;

        public Album(string albumName)
        {
            _albumName = albumName;
            _components = new List<IComponent>();
        }

        public void AddElement(IComponent component)
        {
            _components.Add(component);
        }

        public void AddTag(string tagName)
        {
            foreach (var component in _components)
            {
                component.AddTag(tagName);
            }
        }

        public void Render()
        {
            foreach (var component in _components)
            {
                component.Render();
            }
        }
    }
}