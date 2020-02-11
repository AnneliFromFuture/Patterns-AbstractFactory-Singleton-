using System;
using Composite.Components;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackPanel = new StackPanel("stackPanel");
            var button = new Button("button");
            var textBlock = new TextBlock("textBlock");

            stackPanel.Add(button);
            stackPanel.Add(textBlock);

            //stackPanel.Display(1);


            var stackPanel2 = new StackPanel("stackPanel2");
            var button2 = new Button("button2");
            var textBlock2 = new TextBlock("textBlock2");

            stackPanel2.Add(button2);
            stackPanel2.Add(textBlock2);

            stackPanel.Add(stackPanel2);
            stackPanel.Display(1);

            Console.ReadLine();

            
        }
    }
}
