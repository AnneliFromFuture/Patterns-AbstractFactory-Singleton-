using System;

namespace Composite
{
    public abstract class Component
    {
        private string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Display(int depth);

        public abstract void Add(Component component);

        public abstract void Remove(Component component);
    }
}
