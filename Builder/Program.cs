using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var cupcakeBuilder = new CupcakeBuilder();
            var applePieBuilder = new ApplePieBuilder();
            var weddingCakeBuilder = new WeddingCakeBuilder();

            director.Builder = cupcakeBuilder;
            Console.WriteLine("Making cupcakes:");
            director.MakeCupcakes();
            Console.WriteLine(cupcakeBuilder.GetDessert().GetListOfSteps());


            director.Builder = applePieBuilder;
            Console.WriteLine("Making apple pie:");
            director.MakeApplePie();
            Console.WriteLine(applePieBuilder.GetDessert().GetListOfSteps());

            director.Builder = weddingCakeBuilder;
            Console.WriteLine("Making wedding cake:");
            director.MakeWeddingCake();
            Console.WriteLine(weddingCakeBuilder.GetDessert().GetListOfSteps());

            Console.Read();
        }
    }
}
