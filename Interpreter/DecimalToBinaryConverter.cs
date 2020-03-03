using System;
using System.Collections.Generic;
using System.Linq;

namespace Interpreter
{
    class DecimalToBinaryConverter : AbstractConverter
    {
        public override string Convert(Context context)
        {
            int inputNumber;
            try
            {
                inputNumber = int.Parse(context.Input);
            }
            catch (Exception)
            {
                return "int parse exception";
            }

            var result = new List<string>();
            while (inputNumber > 0)
            {
                var residual = inputNumber % 2;
                inputNumber /= 2;
                result.Insert(0, residual.ToString());
            }

            return result.Aggregate("", (current, symbol) => current + symbol);
        }
    }
}
