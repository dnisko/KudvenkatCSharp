using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Services;
using System.Threading;


class Program
{
    /*   LESSION1 - HELLO WORLD*/

    /* 
 * static void Main1()
{
    Console.WriteLine("Hello world1");
    //Console.ReadLine();
}

static void Main()
{
    Console.WriteLine("Hello world");
    //Console.ReadLine();
    Main1();
}
*/

    /* LESSION 2 - READ & WRITE TO CONSOLE*/

    /*
     * static void Main()
    {
        Console.WriteLine("Enter firstname: ");
        string FirstName = Console.ReadLine();

        Console.WriteLine("Enter lastname: ");
        string LastName = Console.ReadLine();

        Console.WriteLine("Your name is {0}, {1}", FirstName, LastName);

        //Console.WriteLine("your name is " + UserName);
    }
    */

    /* LESSION 3 - BUILT-IN TYPES*/

    /*
     * static void Main()
    {
        //int i = 0;
        Console.WriteLine("Min = {0}", int.MinValue);
        Console.WriteLine("Min = {0}", int.MaxValue);

        //float
        Console.WriteLine("Min = {0}", float.MinValue);
        Console.WriteLine("Min = {0}", float.MaxValue);
    }
    */

    /* LESSION 4 - STRING TYPE*/

    /*
    static void Main()
    {
        /* built in types:
         \a - Bell
         \b - backspase
         \f - formfeed
         \n - newline
         \r - carriage return
         \t - horizontal tab
         \v - vertical tab
         \' - '
         \" - "
         \\ - \
         \? - ?
         \ooo - ASCII char in octal notation
         \xhh - ASCII char in hexadecimal notation
         \xhhhh - Unicode in hexadecimal notatio....
         
        string Name = "\"Dino\"";
        Name = "One\nTwo\nThree";
        Name = "C:\\Dino\\DotNet\\Training\\Csharp";
        Name = @"C:\Dino\DotNet\Training\Csharp";
        Console.WriteLine(Name);

    }
    */

    /* LESSION 5 - COMMON OPERATORS*/

    /*
     static void Main()
    {
        //assingmet - =
        //arithmetic - +, -, +, /, %
        //comparison - ++, !=, >, >=, <, <=
        //conditional - &&, ||
        //ternary - ?:
        //null coalescing - ??
        int Numerator = 10;
        int Denominator = 2;

        int result = Numerator / Denominator;

        Console.WriteLine("Result = {0}", result);

        int Number = 10;
        int AnotherNum = 20;

        if (Number != 10)
        {
            Console.WriteLine("Not 10");
        }
        else
            Console.WriteLine("is 10");

        if(Number == 11 || AnotherNum==20)
        {
            Console.WriteLine("Hello");
        }

        int number1 = 10;
        bool IsNumber10;

        //if (number1==10)
        //{
        //   IsNumber10 = true;
        //
        //}
        //else
        //{
        //    IsNumber10 = false;
        //}

        //oneliner
        IsNumber10 = number1 == 10 ? true : false;

        Console.WriteLine("Number == 10 is {0}", IsNumber10);
    }
    */

    /* LESSION 6 - NULLABLE TYPES*/

    /*

        static void Main()
        {
            //string Name = null;

            //int i = null;
            //int? i = null;
            //use: if a int is not mandatory (bool like AreYouMajor - true; false; not answered


            //bool? areYouMajor = false;

            //if (areYouMajor == true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (areYouMajor == false)
            //    //(!areYouMajor.Value) - throws exception because .Value returns only true or false 
            //{
            //    Console.WriteLine("User is Not Major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer");
            //}
            //
            //int? TicketsOnSale = null;

            //oneliner
            //int availabletickets = ticketsonsale ?? 0;
            //
            //int AvailableTickets;
            //
            //if (TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    AvailableTickets = (int)TicketsOnSale; //Must cast because of nullable
            //}

            Console.WriteLine("Available tickets = {0}", AvailableTickets);
        }
    */

    /* LESSION 7 - DATATYPE CONVERSIONS*/

    /*
    static void Main()
    {
        //int i = 100;
        //
        //float f = i;

        //float f = 123789632118645897.45F;
        //int i = (int)f;
        //
        ////int i = Convert.ToInt32(f);
        //
        //Console.WriteLine(i);

        string strNumber = "100asd";

        //int i = int.Parse(strNumber);
        int Result = 0;
        bool isConversionSuccess = int.TryParse(strNumber, out Result);

        if (isConversionSuccess)
        {

            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("please insert valid number");
        }
    }
    */

    /* LESSION 8 - ARRAYS */

    /*
    static void Main()
    {
        int[] evenNumbers = new int[3];

        evenNumbers[0] = 0;
        evenNumbers[1] = 2;
        evenNumbers[2] = 4;
        //evenNumbers[3] = 6;

        Console.WriteLine(evenNumbers[1]);

    }
    */

    /* LESSION 9 - COMMENTS */

    /*
        //ctrl+k, ctrl+c
        //ctrl+k, ctrl+u

        // - singleline comment
        //multiple so *
        // /// - XML comment

    static void Main()
    {
        SampleClass
    }

    /// <summary>
    /// This is a sample class and a sample documentation
    /// </summary>
    public class SampleClass
    {

    }
    */

    /* LESSION 10 - IF STATEMENT */

    /*
    static void Main()
    {
        Console.WriteLine("Enter number ");

        int userNumber = 20;//int.Parse(Console.ReadLine());


        //if (userNumber == 1)
        //{
        //    Console.WriteLine("Your number is one");
        //}
        //
        //else if (userNumber == 2)
        //{
        //    Console.WriteLine("Your number is two");
        //}
        //
        //else if (userNumber == 3)
        //{
        //    Console.WriteLine("Your number is three");
        //}
        //
        //else //(userNumber != 1 && userNumber != 2 && userNumber != 3)
        //{
        //    Console.WriteLine("Your number is not between 1 and 3");
        //}

        if (userNumber == 10 || userNumber == 20)
        {
            Console.WriteLine("Your number is 10 or 20");
        }
        else
        {
            Console.WriteLine("Your number is not 10 or 20");
        }
    }
    */

    /* LESSION 11 - SWITCH STATEMENT - PART 1 */

    /*
    static void Main()
    {
        Console.WriteLine("Please enter number");
        int userNumber = int.Parse(Console.ReadLine());

        switch (userNumber)
        {
            case 10:
                //Console.WriteLine("your number is 10");
                //break;
            case 20:
                //Console.WriteLine("your number is 20");
                //break;
            case 30:
                Console.WriteLine("your number is {0}", userNumber);
                break;
            default:
                Console.WriteLine("your number is not 10, 20 or 30");
                break;
        }

    }
    */

    /* LESSION 12 - SWITCH STATEMENT - PART 2 */

    /*
        static void Main()
        {
            int TotalCoffeCost = 0;

            Start:
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    TotalCoffeCost += 1;
                    break;
                case 2:
                    TotalCoffeCost += 2;
                    break;
                case 3:
                    TotalCoffeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid.", userChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you want to buy another coffee - Yes or No");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToLower())
            {
                case "yes":
                    goto Start;
                case "no":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid. Please try again...", userDecision);
                    goto Decide;

            }

            Console.WriteLine("Thank you for shopping with us\nBill Amount = {0}", TotalCoffeCost);


        }
        */

    /* LESSION 13 - WHILE LOOP */

    /*
    static void Main()
    {
        Console.WriteLine("enter target number");
        int targetNumber = int.Parse(Console.ReadLine());

        int start = 0;

        while (start <= targetNumber)
        {
            Console.Write(start + " ");
            start = start + 2;
        }
    }
    */

    /* LESSION 14 - DO WHILE LOOP */

    /*
    static void Main()
    {
        //string userChoice = "";
        //do
        //{
        //    Console.WriteLine("enter target number");
        //    int targetNumber = int.Parse(Console.ReadLine());
        //
        //    int start = 0;
        //
        //    while (start <= targetNumber)
        //    {
        //        Console.Write(start + " ");
        //        start += 2;
        //    }
        //    do
        //    {
        //        Console.WriteLine("\n\nDo you want to continue - Yes or No");
        //        userChoice = Console.ReadLine();
        //
        //        if (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no")
        //        {
        //            Console.WriteLine("invalid choice, please write yes or no");
        //        }
        //    } while (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no");
        //
        //} while (userChoice.ToLower() == "yes");

        int totalCost = 0;
        string userDecision = string.Empty;
        do
        {
            int userChoice = 0;
            do
            {
                Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        totalCost += 1;
                        break;
                    case 2:
                        totalCost += 2;
                        break;
                    case 3:
                        totalCost += 3;
                        break;
                    default:
                        Console.WriteLine("Your choice {0} is invalid.", userChoice);
                        break;
                }
            } while (userChoice != 1 && userChoice != 2 && userChoice != 3);

            do
            {
                Console.WriteLine("Do you want to buy another coffee - Yes or No");
                userDecision = Console.ReadLine().ToLower();

                if (userDecision != "yes" && userDecision != "no")
                {
                    Console.WriteLine("invalid choice {0}, please write yes or no", userDecision);
                }

            } while (userDecision != "yes" && userDecision != "no");
        } while (userDecision.ToLower() != "no");

        Console.WriteLine("thank you for shopping\nBill amount = {0}", totalCost);
    }
    */

    /* LESSION 15 - FOR AND FOREACH LOOP */

    static void Main()
    {

    }


    /* LESSION 16 - METHODS */
}

