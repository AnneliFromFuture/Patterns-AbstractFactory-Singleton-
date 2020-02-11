using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Components;

namespace Composite
{
    class UserControl : Component
    {
        protected List<Button> _children = new List<Button>();
        private string _name;

        public UserControl(string name) : base(name)
        {

        }

        public void Remove(Button button)
        {
            _children.Remove(button);
        }

        public void Add(Button button)
        {
            _children.Add(button);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);

            foreach (Button component in _children)
            {
                component.Display(depth + 2);
            }

        }
    }
}
