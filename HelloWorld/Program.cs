using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];

            age[1] = 15;

            string ingreso = Console.ReadLine();
            age[1] = int.Parse(ingreso);

            Console.WriteLine(age[1]);

            int[] age2 = { 17, 15, 17, 20, 5 };
            int[] dates = new int[] {3, 5, 6, 7, 8, 12};

            Console.WriteLine(age.Length);
            Console.WriteLine(dates.Length);
            dates.Append(10);
            foreach (var date in dates)
            {
                Console.WriteLine(date);
            }
        }
    }
}