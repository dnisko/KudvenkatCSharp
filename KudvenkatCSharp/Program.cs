using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Threading;
using static System.Console;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;
//using PATA = ProjectA.TeamA;
//using PATB = ProjectA.TeamB;

class Program
{
    /*   LESSON 1 - HELLO WORLD*/

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

    /* LESSON 2 - READ & WRITE TO CONSOLE*/

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

    /* LESSON 3 - BUILT-IN TYPES*/

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

    /* LESSON 4 - STRING TYPE*/

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

    /* LESSON 5 - COMMON OPERATORS*/

    /*
     static void Main()
    {
        //assignment - =
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

    /* LESSON 6 - NULLABLE TYPES*/

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

    /* LESSON 7 - DATATYPE CONVERSIONS*/

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

    /* LESSON 8 - ARRAYS */

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

    /* LESSON 9 - COMMENTS */

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

    /* LESSON 10 - IF STATEMENT */

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

    /* LESSON 11 - SWITCH STATEMENT - PART 1 */

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

    /* LESSON 12 - SWITCH STATEMENT - PART 2 */

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

    /* LESSON 13 - WHILE LOOP */

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

    /* LESSON 14 - DO WHILE LOOP */

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

    /* LESSON 15 - FOR AND FOREACH LOOP */

    /*
    static void Main()
    {
        //int[] Numbers = new int[3];
        //
        //Numbers[0] = 101;
        //Numbers[1] = 102;
        //Numbers[2] = 103;
        //
        //
        //
        //
        //foreach (int k in Numbers)
        //{
        //    Console.WriteLine(k);
        //}
        //
        //for (int j = 0; j < Numbers.Length; j++)
        //{
        //    Console.WriteLine(Numbers[j]);
        //}
        //
        //int i = 0;
        //while (i < Numbers.Length)
        //{
        //    Console.WriteLine(Numbers[i]);
        //    i++;
        //}

        for (int i = 0; i <= 20; i++)//i+=2 - even numbers
        {
            if (i % 2 == 1)
                continue;

            Console.WriteLine(i);

            //if (i == 10)
            //    break;

        }
    }
    */

    /* LESSON 16 - METHODS */

    /*
    public static void Main()
    {
        //public void EvenNumbers()
        //Program p = new Program();
        //p.EvenNumbers();

        //public static void EvenNumbers()
        EvenNumbers(30);

        Program p = new Program();
        int sum = p.Add(10, 20);

        Console.WriteLine("Sum = {0}", sum);

    }

    public int Add(int FN, int SN)
    {
        return FN + SN;
    }

    public static void EvenNumbers(int target)
    {
        //for (int i = 0; i <= 20; i++)
        //{
        //    if (i % 2 == 1)
        //        continue;
        //
        //    Console.WriteLine(i);
        //}

        int start = 0;

        while (start <= target)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }
    */

    /* LESSON 17 - METHOD PARAMETERS */

    /*
    public static void Main()
    {
                //  VALUE PARAMETER
        //int i = 0;
        //SimpleMethod(i)
        //
        //Console.WriteLine(i);


                //  REFERENCE PARAMETER
        //int i = 0;
        //SimpleMethod(ref i)
        //
        //Console.WriteLine(i);

                // OUT PARAMETER
        //int total = 0;
        //int product = 0;
        //Calculate(10,20, out total, out product);
        //
        //Console.WriteLine("Sum = {0} and Product = {1}", total, product);

                // PARAMETER ARRAYS
        int[] Numbers = new int[3];

        Numbers[0] = 101;
        Numbers[1] = 102;
        Numbers[2] = 103;

        //ParamsMethod();
        //ParamsMethod(Numbers);
        ParamsMethod(1,2,3,4,5,6,7);

    }

    public static void ParamsMethod(int x, params int[] numbers)//params always last
    {
        Console.WriteLine("Total elements in array {0}", numbers.Length);

        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    //OUT PARAMETER
    public static void Calculate(int FN, int SN, out int Sum, out int Product)
    {
        Sum = FN + SN;
        Product = FN * SN;
    }

    //VALUE & PARAMETER REFERENCE
    public static void SimpleMethod(ref int j)//W/O ref - value reference
    {
        j = 101;
    }

    */

    /* LESSON 18 - NAMESPACES */

    /*
    public static void Main()
    {
        //ProjectA.TeamA.ClassA.Print();
        PATA.ClassA.Print();
        //ProjectA.TeamB.ClassA.Print();
        PATB.ClassA.Print();
    }


    //namespace ProjectA
    //{
    //    namespace TeamA
    //    {
    //        class ClassA
    //        {
    //            public static void Print()
    //            {
    //                Console.WriteLine("Team A Print Method");
    //            }
    //        }
    //    }
    //}
    //
    //namespace ProjectA
    //    {
    //        namespace TeamB
    //        {
    //            class ClassA
    //            {
    //                public static void Print()
    //                {
    //                    Console.WriteLine("Team B Print Method");
    //                }
    //            }
    //        }
    //
    //    }
    */

    /* LESSON 19 - CLASSES*/

    /*
    class Customer
    {
        string _firstname;
        string _lastname;


        public Customer() 
            : this("No FirstName Provided", "No LastName provided")
        {

        }

        public Customer(string FirstName, string LastName)
        {
            this._firstname = FirstName;
            this._lastname = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full name = {0} {1}", this._firstname, this._lastname);
        }

        ~Customer()//destructor
        {
            //clean up code
        }
    }


    static void Main()
    {
        Customer C1 = new Customer();
        C1.PrintFullName();

        Customer C2 = new Customer("Dino", "Nikolovski");
        C2.PrintFullName();
    }
    */

    /* LESSON 20 - STATIC AND INSTANCE CLASS MEMBERS*/

    /*
    class Circle
    {
        public static float _PI;// = 3.141F;
        int _Radius;

        static Circle()
        {
            WriteLine("Static Constructor Called");
            Circle._PI = 3.141F;
        }

        public Circle(int Radius)
        {
            WriteLine("Instance Constructor Called");
            this._Radius = Radius;
        }

        public static void Print()
        {
            WriteLine("This is static Method");
        }

        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }
    }


    public static void Main()
    {
        //Circle C1 = new Circle(5);
        //float Area1 = C1.CalculateArea();
        //Circle.Print();
        //WriteLine("Area = {0}", Area1);

        //Circle C2 = new Circle(6);
        //float Area2 = C2.CalculateArea();
        //WriteLine("Area = {0}", Area2);

        WriteLine(Circle._PI);//public static float_PI
    }
    */

    /* LESSON 21 - INHERITANCE */

    /*
    public class ParentClass
    {
        public ParentClass()
        {
            WriteLine("ParentClass Constructor Called");
        }

        public ParentClass(string message)
        {
            WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Derived class controlling Parent Class") //base calls constructor of your choice
        {
            WriteLine("ChildClass Constructor Called");
        }
    }

    public static void Main()
    {
        ChildClass CC = new ChildClass();

        //FullTimeEmployee FTE = new FullTimeEmployee();
        //FTE.FirstName = "Dino";
        //FTE.LastName = "Nikolovski";
        //FTE.Email = "Dino@dino.com";
        //FTE.YearlySalary = 50000;
        //
        //FTE.PrintFullName();
        //
        //PartTimeEmployee PTE = new PartTimeEmployee();
        //PTE.FirstName = "Part";
        //PTE.LastName = "Time";
        //PTE.Email = "PART@dino.com";
        //PTE.HourlyRate = 10;
        //
        //PTE.PrintFullName();
        //
        //
        //A a1 = new A(); //multi level class inheritance


    }
    }

    public class Employee
    {
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        WriteLine(FirstName + " " + LastName);
    }
    }

    public class FullTimeEmployee : Employee
    {
    public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
    public float HourlyRate;

    }

    public class A : PartTimeEmployee //multi level class inheritance
    {

    }

    */

    /* LESSON 22 - METHOD HIDING*/

    /*
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "FullTime";
        FTE.LastName = "Employee";
        FTE.YearlySalary = 50000;

        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "PartTime";
        PTE.LastName = "Employee";
        //PTE.HourlyRate = 10;

        PTE.PrintFullName(); //calls method from PartTime
        //((Employee)PTE).PrintFullName(); //calls method from employee
    }
    }

    public class Employee
    {
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        WriteLine(FirstName + " " + LastName);
    }
    }

    public class FullTimeEmployee : Employee
    {
    public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
    public new void PrintFullName() //hides the PrintFullName from Employee
    {
        //base.PrintFullName();
        WriteLine(FirstName + " " + LastName + " - Constructor");
    }
    public float HourlyRate;

    }
    */

    /* LESSON 23 - POLYMORPHISM */

    /*
            // polymorphism enables us to invoke derived class methods trough a base class reference during runtime
        public static void Main()
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
        }
    }

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName() //must be virtual to override
        {
            WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            WriteLine(FirstName + " " + LastName + " - Temporary");
        }
    }
    */

    /* LESSON 24 - DIFFERENCE BETWEEN METHOD OVERRIDING AND METHOD HIDING */

    /*
        public static void Main()
        {
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();
        }
    }

    public class BaseClass
    {
        public virtual void Print() //virtual = override, 
        {
            WriteLine("I am a Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void Print() //override = overriding, new = hiding
        {
            WriteLine("I am a Derived Class Print Method");
        }
    }
    */

    /* LESSON 25 - METHOD OVERLOADING */

    /*
        public static void Main()
        {
            Add(1,2);
        }

        public static void Add(int FN, int SN, params int[] TN)
        {
            WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int[] TN)
        {
            WriteLine("Sum = {0}", FN + SN);
        }

    */

    /* LESSON 26 - WHY PROPERTIES */

    /*
        public static void Main()
        {
            Student S1 = new Student();
            S1.SetId(101);
            S1.SetName("Dino");

            WriteLine("Student ID = {0}", S1.GetId());
            WriteLine("Student Name = {0}", S1.GetName());
            WriteLine("Student PassMark = {0}", S1.GetPassMark());
            //S1.Name = null;
            //S1.PassMark = 0;

            //WriteLine("ID - {0} && Name = {1} && PassMark = {2}", S1.ID, S1.Name, S1.PassMark);
        }
    }

    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;

        public int GetPassMark()
        {
            return this._passMark;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be null or empty");
            }

            this._Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
            //if (string.IsNullOrEmpty(this._Name))
            //{
            //    return "No Name";
            //}
            //else
            //{
            //    return this._Name;
            //}
        }

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("Student Id cannot be negative");
            }

            this._id = Id;
        }

        public int GetId()
        {
            return this._id;
        }
    }
    */


    /* LESSON 27 - PROPERTIES */

    /*
    //GET = READ ONLY
    //SET = WRITE ONLY
    public class Student
    {
        private int _id;
        private string _Name;
        private int _passMark = 35;
        //private string _city;
        //private string _email;

        public string City { get; set; }

        public string Email { get; set; }

        public int PassMark //one liner = public int PassMark => this._passMark;
        {
            get
            {
                return this._passMark;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be null or empty");
                }

                this._Name = value;
            }
            get => string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }

        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }

                this._id = value;
            }
            get => this._id;
        }

    }

    public static void Main()
    {
        Student S1 = new Student();
        S1.Id = 101;
        S1.Name = "Dino";

        WriteLine("Student ID = {0}", S1.Id);
        WriteLine("Student Name = {0}", S1.Name);
        WriteLine("PassMark = {0}", S1.PassMark);
        //S1.Name = null;
        //S1.PassMark = 0;

        //WriteLine("ID - {0} && Name = {1} && PassMark = {2}", S1.ID, S1.Name, S1.PassMark);
    }

}
*/

    /* LESSON 28 - STRUCTS */

    /*

    public struct Customer
    {
        private int _id;//auto get and set - CTRL+R, E
        private string _name;

        public string Name { get => _name; set => _name = value; }
        public int Id { get => _id; set => _id = value; }

        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public void PrintDetails()
        {
            WriteLine("id = {0} && Name = {1}", this._id, this._name);
        }
    }
    public static void Main()
    {
        Customer C1 = new Customer(101, "Dino");
        C1.PrintDetails();

        Customer C2 = new Customer();
        C2.Id = 102;
        C2.Name = "Dinko";
        C2.PrintDetails();

        var c3 = new Customer
        {
            Id = 103,
            Name = "Rob"
        };
        c3.PrintDetails();
    }
}*/

    /* LESSON 29 - DIFFERENCE BETWEEN CLASSES AND STRUCTS */

    /*
    //STRUCT - VALUE TYPE, DESTROYED IMMEDIATELY, CANNOT HAVE DESTRUCTOR, CANNOT HAVE EMPTY CONSTRUCTOR
            //CANNOT INHERIT FROM ANOTHER STRUCT

    //CLASS - REFERENCE TYPE

    public class Customer //sealed - to restrict inheritance
    {
        public int ID { get; set; }
        public string Name { get; set; }

        ~Customer()
        {

        }
    }

    public static void Main()
    {
       // int i = 0;
       // if (i == 10)
       // {
       //     var j = 20;
       //     var c1 = new Customer
       //     {
       //         ID = 101, Name = "Mark"
       //     };
       // }
       // WriteLine("Hello");//var j is destroyed

       //int i = 10;
       //int j = i;
       //j += 1;
       //
       //WriteLine("i = {0} && j = {1}", i, j);
       //Customer c1 = new Customer();
       //c1.ID = 101;
       //c1.Name = "Mark";
       //
       //Customer c2 = c1;
       //c2.Name = "Marry";
       //
       //WriteLine("C1.Name = {0} && c2.Name = {1}", c1.Name, c2.Name);

    }
}
*/

    /* LESSON 30 - INTERFACES */

    /*
    //INTERFACES - CANNOT IMPLEMENT
                //PUBLIC BY DEFAULT
                //CANNOT CONTAIN FIELDS
                //CAN INHERIT FORM MULTIPLE INTERFACES
                // CANNOT CREATE AN INSTANCE OF INTERFACE BECAUSE THERE ARE NO IMPLEMENTATIONS
    
    //CLASS - IF A CLASS INHERITS FROM INTERFACE IT MUST PROVIDE IMPLEMENTATION FOR ALL INTERFACE MEMBERS
                //CAN INHERIT FROM MULTIPLE INTERFACES
                //CANNOT INHERIT FROM MULTIPLE CLASSES
                //CAN INHERIT FORM MULTIPLE INTERFACES
    interface ICustomer1
    {
        void ICustomer1Print();//public by default
        // cannot have definition od implementation
        //{
        //    WriteLine("Hello");
        //}

        //int ID; //cannot have fields
    }

    interface ICustomer2 : ICustomer1
    {
        void ICustomer2Print();
    }

    class Customer : ICustomer2//must implement all methods
    {
        public void ICustomer1Print()
        {
            WriteLine("ICustomer1 Print Method");
        }

        public void ICustomer2Print()
        {
            WriteLine("ICustomer2 Print Method");
        }
    }

    class Sample
    {

    }

    //public class Sample1 : Sample, Customer//cannot inherit form multiple classes
    //{
    //
    //}
    public static void Main()
    {
        Customer c1 = new Customer();
        c1.ICustomer1Print();
        c1.ICustomer2Print();

        ICustomer1 Cust = new Customer();
        WriteLine("\nReference of ICustomer1 ");
        Cust.ICustomer1Print();
    }
    
}
*/

    /* LESSON 31 - EXPLICIT INTERFACES IMPLEMENTATION */

    /*
    public static void Main()
    {
        //Class c1 = new Class();
        //((I1)c1).InterfaceMethod();
        //((I2)c1).InterfaceMethod();

        //I1 i1 = new Class();
        //I2 i2 = new Class();
        //
        //i1.InterfaceMethod();
        //i2.InterfaceMethod();

        Class C = new Class();
        C.InterfaceMethod();
        ((I2)C).InterfaceMethod();
    }
}

interface I1
    {
        void InterfaceMethod();
    }

interface I2
{
    void InterfaceMethod();
}

class Class : I1, I2
{
    public void InterfaceMethod()
    {
        WriteLine("I1 Interface Method");
    }
    void I2.InterfaceMethod()
    {
        WriteLine("I2 Interface Method");
    }
}
*/

    /* LESSON 32 - ABSTRACT CLASSES */

    /*
    //HAS TO IMPLEMENT ALL METHODS FROM INHERITANCE OR MAKE THE CLASS ABSTRACT
    abstract class Customer
    {
        //public abstract void Print();
        public void Print()
        {
            WriteLine("Print Method");
        }
    }

    class Class : Customer
    {
        //public override void Print()
        //{
        //    WriteLine("Print Method");
        //}
    }
    public static void Main()
    {
        Class C = new Class();
        C.Print();
    }
}
*/

    /* LESSON 33 - DIFFERENCE BETWEEN ABSTRACT CLASS AND INTERFACES */

    /*
    //ABSTRACT CLASS - CAN HAVE IMPLEMENTATIONS
    //CAN HAVE FIELDS
    //CAN INHERIT FROM MULTIPLE INTERFACE
    //CAN HAVE ACCESS MODIFIERS

    //INTERFACE - CANNOT INHERIT FROM ABSTRACT CLASS, ONLY FROM INTERFACE
    //CANNOT HAVE ACCESS MODIFIERS

    public abstract class Customer
    {
        int ID;
        public void Print()
        {
            WriteLine("Abstract Class");
        }
    }

    public interface ICustomer
    {
        //cannot have  impementations
        //public void Print()
        //{
        //    WriteLine("Abstract Class");
        //}

        //cannot have fields
        //int ID;

    }

    public static void Main()
    {

    }
    */

    /* LESSON 34 - PROBLEMS OF MULTIPLE CLASS INHERITANCE */

    /*
    class A
    {
        public virtual void Print()
        {
            WriteLine("A Implementation");
        }
    }

    class B : A
    {
        public override void Print()
        {
            WriteLine("B Implementation");
        }
    }
    class C : A
    {
        public override void Print()
        {
            WriteLine("C Implementation");
        }
    }
    class D : B, C //CANNOT INHERIT FROM MULTIPLE CLASSES, BECAUSE D WILL NOT KNOW WHICH PRINT METHOD TO PRINT
    {
        public void Print()
        {
            WriteLine("B Implementation");
        }
    }
    public static void Main()
    {

    }
    */

    /* LESSON 35 - MULTIPLE CLASS INHERITANCE USING INTERFACE */

    /*
    interface IA
    {
        void AMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }

    class B : IB
    {
        public void BMethod()
        {
            WriteLine("B");
        }
    }

    class AB : IA, IB
    {
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }

    public static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }

    */

    /* LESSON 36 - DELEGATES */

    /*
    //delegate is a type safe function pointer (points to a same type signature)

    public delegate void HelloFunctionDelegate(string Message);

    public static void Main()
    {
        HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
        //del.Invoke("Dino");
        del("Hello from delegate");
    }

    public static void Hello(string strMessage)
    {
        WriteLine(strMessage);
    }
    */

    /* LESSON 37/38 - DELEGATES USAGE */

    /*
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();

        empList.Add(new Employee() {ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
        empList.Add(new Employee() {ID = 102, Name = "Mike", Salary = 4000, Experience = 4});
        empList.Add(new Employee() {ID = 103, Name = "John", Salary = 6000, Experience = 6});
        empList.Add(new Employee() {ID = 104, Name = "Todd", Salary = 3000, Experience = 3});

        //IsPromotable isPromotable = new IsPromotable(Promote);


        Employee.PromoteEmployee(empList, emp => emp.Experience >=5); //isPromotable);
    }

    //public static bool Promote(Employee emp)
    //{
    //    if (emp.Experience >= 5)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
}

delegate bool IsPromotable(Employee empl);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isEligibleToPromotable)
        {
            foreach (Employee employee in employeeList)
            {
                if (isEligibleToPromotable(employee))
                {
                    WriteLine(employee.Name + " promoted");
                }
            }
        }
    }
    */

    /* LESSON 39 - MULTI CAST DELEGATES */

    /*
        //public delegate void SampleDelegate();
        //public delegate int SampleDelegate();
        public delegate void SampleDelegate(out int Integer);

        public static void Main()
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            //int DelegateReturnValue = del();
            int DelegateOutputParameterValue = -1;

            del(out DelegateOutputParameterValue);


            WriteLine("DelegateReturnedValue = {0}", DelegateOutputParameterValue);
            //WriteLine("DelegateReturnValue {0}", DelegateReturnValue);

            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodTwo;
            //del += SampleMethodThree;
            //del += SampleMethodFour;
            //del();

            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);
            //
            //del4 = del1 + del2 + del3 - del2;
            //del4();
        }

        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
            //WriteLine("SampleMethodOne Invoked");
        }
        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
            //WriteLine("SampleMethodTwo Invoked");
        }
        public static void SampleMethodThree(out int Number)
        {
            Number = 3;
            //WriteLine("SampleMethodThree Invoked");
        }
        //public static void SampleMethodFour()
        //{
        //    WriteLine("SampleMethodFour Invoked");
        //}

        public static int SampleMethodOne()
        {
            return 1;
        }
        public static int SampleMethodTwo()
        {
            return 2;
        }
        */

    /* LESSON 40 - EXCEPTION HANDLING */

    /*
    public static void Main()
    {
        StreamReader s = null;
        try
        {
            string filepath = @"..\sample files\log.txt";
            s = new StreamReader(filepath);
            WriteLine(s.ReadToEnd());
        }
        catch (FileNotFoundException e)
        {
            WriteLine("Please check if file {0} exist", e.FileName);
            //WriteLine(e.Message);
            //WriteLine();
            //WriteLine();
            //WriteLine(e.StackTrace);
        }
        catch (Exception ex) //cannot be first catch
        {
            Write(ex.Message);
        }

        if (s != null)
        {
            s.Close();
        }

        WriteLine("Finally block");
        //finally
        //{
        //    if (s != null)
        //    {
        //        s.Close();
        //    }
        //
        //    WriteLine("Finally block");
        //}
    }

    */

    /* LESSON 41 - INNER EXCEPTION */

    /*
    public static void Main()
    {
        try
        {
            try
            {
                WriteLine("enter first number");
                int FN = Convert.ToInt32(ReadLine());

                WriteLine("enter second number");
                int SN = Convert.ToInt32(ReadLine());

                int result = FN / SN;

                WriteLine("Result = {0}", result);

            }
            catch (Exception e)
            {
                string filepath = @"..\sample files\log1.txt";

                if (File.Exists(filepath))
                {
                    StreamWriter sw = new StreamWriter(filepath);
                    sw.Write(e.GetType().Name);
                    sw.WriteLine();
                    sw.Write(e.Message);
                    sw.Close();
                    WriteLine("There is problem, try again");
                }
                else
                {
                    throw new FileNotFoundException(filepath + " does not exist", e);
                }
            }
        }
        catch (Exception ex)
        {
            WriteLine("Current exception = {0}", ex.GetType().Name);
            if (ex.InnerException != null)
            {
                WriteLine("Inner exception = {0}", ex.InnerException.GetType().Name);
            }
        }

    */

    /* LESSON 42 - CUSTOM EXCEPTION */

    public static void Main()
    {

    }


    /* LESSON 43 - EXCEPTION HANDLING ABUSE */
}
