using System.Collections.Generic;

namespace Builder
{
    public class Dessert
    {
        private List<object> _steps = new List<object>();

        public void Add(string step)
        {
            _steps.Add(step);
        }

        public string GetListOfSteps()
        {
            var str = string.Empty;

            for (var i = 0; i < _steps.Count; i++)
            {
                str += _steps[i] + "\n";
            }

            return "Dessert parts: " + "\n" + str;
        }
    }
}
