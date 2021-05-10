using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.WriteLine("Please type number of operation you wish to perform and press enter.");
                Console.WriteLine("1: add");
                Console.WriteLine("2: subtract");
                Console.WriteLine("3: multiply");
                Console.WriteLine("4: divide");
                Console.WriteLine("5: modulo");
                Console.WriteLine("6: raise by power(base and then exponent)");
                Console.WriteLine("7: factorial");
                string inputText = Console.ReadLine();
                int selection;
                int.TryParse(inputText, out selection);
                Console.WriteLine("Please type the first operand and press enter.");
                string input1 = Console.ReadLine();
                //if selection isn't factorial.
                int y = 0;
                if (selection != 7)
                {
                    Console.WriteLine("Please type the second operand and press enter.");
                    string input2 = Console.ReadLine();
                    y = Int32.Parse(input2);
                }
                int x = Int32.Parse(input1);


                switch (selection)
                {

                    case 1:
                        Console.WriteLine("Result: " + (x + y));
                        break;
                    case 2:
                        Console.WriteLine("Result: " + (x - y));
                        break;

                    case 3:
                        Console.WriteLine("Result: " + (x * y));
                        break;

                    case 4:
                        Console.WriteLine("Result: " + (x / y));
                        break;

                    case 5:
                        Console.WriteLine("Result: " +  (x % y));
                        break;

                    case 6:
                        Console.WriteLine("Result: " + Math.Pow(x, y));
                        break;

                    case 7:

                        Console.WriteLine("Results: " +
                            factorial(x));
                        break;


                    default:
                        Console.WriteLine("The number does not match an operation.");
                        break;


                }
                Console.WriteLine("Press Y key if you wish to perform another operation.");
                string input3 = Console.ReadLine();
                if (input3 != "Y")
                {
                    run = false;
                }
                
            }
            //write lines to describe options to user and give each operation a number;
            //read the input from the user.  Should be number associated with the operations.
            //prompt user to enter first number.
            //if the operation requires a second number prompt for it.
            //calculate and output the result.
            //use console.writeline to output text like the hello world above.
            //use console.readline to read the input.  Look up examples of how to use this function and write line if you need.
        }

        public static int factorial(int x)
        {
            int res = 1;
            while (x != 1)
            {
                res = res * x;
                x = x - 1;
            }
            return res;
                    
        }
    }
}


