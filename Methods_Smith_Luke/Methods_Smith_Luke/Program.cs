using System;

namespace Methods_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks for two ints to multiply and saves them
            Console.WriteLine("input an int to multiply");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input another");
            int y = Convert.ToInt32(Console.ReadLine());

            //prints the product of the two ints
            Console.Write("the product of those is ");
            Console.WriteLine(multMeth(x, y));

            //asks for a name and saves it as a string
            Console.WriteLine("input your name");
            string name = Console.ReadLine();

            //prints a greeting
            Console.WriteLine(stringMeth(name));
        }
        static int multMeth(int x, int y)
        {
            //multiplies ints x and y then returns the product
            return (x * y);
        }
        static string stringMeth(string name)
        {
            //writes the greeting then returns it
            return $"Hello {name}! It is nice to meet you!";
        }
    }
}
