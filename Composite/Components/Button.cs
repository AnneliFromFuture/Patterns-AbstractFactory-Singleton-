using System;

namespace Composite.Components
{
    public class Button : Component
    {
        private string _name;

        public Button(string name) : base(name)
        {
            _name = name;
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }
    }
}
