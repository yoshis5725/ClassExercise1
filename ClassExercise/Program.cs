using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car()
            {
                Make = "BMW",
                Model = "528i",
                Year = 2012
            };

            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}

