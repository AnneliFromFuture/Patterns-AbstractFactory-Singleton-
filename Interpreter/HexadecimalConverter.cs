using System;

namespace Interpreter
{
    class HexadecimalConverter : AbstractConverter
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

            return System.Convert.ToString(inputNumber, 16);
        }
    }
}
