
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalculatorApp
    {
    class calculatorMachine

    {
        private double firstNumber;
        private double secondNumber;
        private double results;
        private char operation;

        public calculatorMachine(double first, double second, char opp)
        {
            firstNumber = first;
            secondNumber = second;
            operation = opp;
            Switching();
        }
        private void Switching()
        {
            switch (operation)
            {
                case '+':
                    results = firstNumber + secondNumber;
                    Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, results);
                    startover();
                    break;

                case '-':
                    results = firstNumber - secondNumber;
                    Console.WriteLine("The difference of {0} and {1} is {2}", firstNumber, secondNumber, results);
                    startover();
                    break;
                    

                case '*':
                    results = firstNumber * secondNumber;
                    Console.WriteLine("The product of {0} and {1} is {2}", firstNumber, secondNumber, results);
                    startover();
                    break;
                    

                case '/':
                    results = firstNumber / secondNumber;
                    Console.WriteLine("The division of {0} and {1} is {2}", firstNumber, secondNumber, results);
                    startover();
                    break;
                    


                default:
                    Console.WriteLine("Impossible Action! Please Try Again!");
                    End();
                    break;

            }
        }
        private void startover()
        {
            Console.WriteLine("Want To Do Something Else?\nIf \'yes\'then press and enter (Y). \n" +
                "Else enter any key"); 
                
            string YesorNo = Console.ReadLine();
            bool mybool = (YesorNo == "y" || YesorNo == "Y");
            if (mybool==true)
            {
                repeat();
            }
            else
            {
                End();
            }

        }

        private void repeat()
        {
            firstNumber = results;

            Console.WriteLine("Enter Your Second Number:");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Select An Operation: (- , + , * , /)");
            operation = char.Parse(Console.ReadLine());
            Switching();

        }

        private void End()
        {

            Console.WriteLine("Final Result Expected is {0}", results);
            Console.WriteLine("Press Any Key to ESC the calculator");
            Console.ReadKey();
        }

    }
           
        }

   
