using System;
using System.Data;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNum = "4739";

            var context = new Context(decimalNum);

            var binaryConverter = new DecimalToBinaryConverter();
            var binaryResult = binaryConverter.Convert(context);

            var octalConverter = new DecimalToOctalConverter();
            var octalResult = octalConverter.Convert(context);

            var hexadecimalConverter = new HexadecimalConverter();
            var hexadecimalResult = hexadecimalConverter.Convert(context);

            Console.WriteLine(binaryResult);
            Console.WriteLine(octalResult);
            Console.WriteLine(hexadecimalResult);

            Console.ReadKey();
        }
    }
}
