using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------------\n" +
                "----------------------Welcome To Coolbeans Console Calculator---------------\n" +
                "----------------------------------------------------------------------------");

            Console.WriteLine("Enter Your First Number: ");
        {

        }
            double fnum = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Second Number");
            double snum = double.Parse(Console.ReadLine());

            Console.WriteLine("Select An Operation: (-,+, *, /)");
            char myopp = char.Parse(Console.ReadLine());

            calculatorMachine User = new calculatorMachine(fnum, snum, myopp);
            
        }
    }
}
