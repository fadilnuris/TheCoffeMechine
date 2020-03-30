using System;

namespace TheCoffeMechine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            Milk milk = new Milk(200);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water, milk);

            //1
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            //2
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("result " + result);

            //3
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("result " + result);

            //4
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            //5
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result " + result);

            //6
            Console.WriteLine("check " + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEspresso();
            Console.WriteLine("result " + result);

            Console.WriteLine("check " + yummyCoffe.checkAvailability());
        }
    }
}
