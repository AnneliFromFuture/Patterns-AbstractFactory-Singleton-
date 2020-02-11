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

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
