using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class StackPanel : Component
    {
        private List<Component> _children = new List<Component>();
        private string _name;

        public StackPanel(string name) : base(name)
        {
            _name = name;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + _name);

            foreach (var component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override void Add(Component component)
        {
           _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
    }
}
