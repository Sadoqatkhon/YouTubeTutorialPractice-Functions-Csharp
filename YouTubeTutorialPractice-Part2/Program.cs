using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeTutorialPractice_Part2
{
    /*class Test
        {
            // public means accessible from anywhere
            //if you don't use static, you should make new instance of class inside main function, and call methods
            
            //e.g: Test test = new Test() <- in main function
            //test.something()  <- in main function

            //Test.something() - this is how you call function if it is static inside main


            public static void something() //static means you don't need to create an instance
            {
                Console.WriteLine();
            }
        }
        */

    internal class Program
    {    
  
        static void Main(string[] args)
        {
            ////---------------------------------------------------------------------------------------------
            ////--FUNCTIONS
            //// Functions are also called methods, they are used interchangeably
            ////Functions are used to improve readability and reusability of the code
            ////it is important to use static void Main(string[] args) function in .Net Framework, otherwise it won't run



            //WelcomeMessage(); //calling the function
            //Test.something();



            ////---------------------------------------------------------------------------------------------
            //// -- VOID FUNCTIONS - is used to specify return type of a method
            //// void means function doesn't return any value, but if you need ot return some value you need to specify data type when creating a function

            //CreateAndPrintArray();


            ////---------------------------------------------------------------------------------------------
            ////--RETURN TYPE FUNCTIONS
            //// functions are very helpful to reduce repetition of code



            //Console.Title = ReturnNameAgePair() ; //to give title to console window
            //PrintIntroduction();

            //int[] numbers = new int[3];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = ReadNumberFromConsole();
            //}

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + "  ");
            //}
            //Console.WriteLine();

            //int[] newNums = CreateRandomArray();

            //foreach (var item in newNums)
            //{
            //    Console.Write(item + "  ");
            //}
            ///*The goal of function is to make them do as little as possible
            //if your function has 2 different things it is doing or more,
            //then you should break that out into another function*/

            ////---------------------------------------------------------------------------------------------
            ////--FUNCTION PARAMETERS

            //int calc = Add(50, 50);
            //Console.WriteLine(calc);

            //int num = ReadInt("Enter a number");
            //Console.WriteLine(num);

            //int angle = ReadInt("Angle");
            //Console.WriteLine(angle);

            //int firstNum = ReadInt("Enter  first number");
            //int secondNum = ReadInt("Enter second number");
            //int result = Add(firstNum , secondNum);

            //Console.WriteLine(result);

            //int age = ReadInt("Enter your age");
            //string name = ReadString("Enter your name");

            //string details = UserDetails(name, age);
            //Console.WriteLine(details);


            ////---------------------------------------------------------------------------------------------
            ////--OPTIONAL PARAMETERS


            //int result = Add(5);
            //Console.WriteLine(result);

            //PrintName("Lily");

            ////---------------------------------------------------------------------------------------------
            ////--NAMED PARAMETERS

            //string nameInput = "Aba";
            //int ageInput = 21;
            //string addressInput = "1 Smth Street";

            //PrintDetails( age: ageInput, // specifying which argument is for which parameters, now argument order is not important
            //              address: addressInput,
            //              name: nameInput);

            ////---------------------------------------------------------------------------------------------
            ////--OUT PARAMETERS

            //int num = 0;
            //bool success  = test(out num);

            //Console.WriteLine(num); //5
            ////Console.WriteLine(success);

            ////int.TryParse("123", out int result);

            //List<string> shoppingList = new List<string>() { "Coffee", "Milk"};

            //Console.WriteLine(shoppingList.IndexOf("Coffee"));

            ////Console.WriteLine(FindInList("Milk", shoppingList, out int index));
            ////Console.WriteLine(index);

            //Console.Write("Enter an item to search: ");
            //string search = Console.ReadLine();
            //if (FindInList(search, shoppingList, out int index))
            //{
            //    Console.WriteLine($"Found {search} at index {index}");
            //}
            //else
            //{
            //    Console.WriteLine("Not found");
            //}

            //    /*int index = -1; // 0 ->
            //    for (int i = 0; i < shoppingList.Count; i++)
            //    {
            //        if (shoppingList[i].ToLower().Equals("coffee"))
            //        {
            //            index = i;
            //        }
            //    }
            //    bool found = index > -1 ;
            //    Console.WriteLine(found ? "Found" : "Not found");*/

            ////---------------------------------------------------------------------------------------------
            //// --REFERENCE PARAMETERS

            //int num = 10;
            //string name = " ";
            //Assign(ref num, ref name);
            //Console.WriteLine(num +  name);

            //when using an out keyword, you have to assign value to parameters
            //however, ref (reference)  keyword doesn't require value passing
            
            //string name = "Joe";

            //Console.Write("Enter your name: ");

            //string newName = Console.ReadLine();

            //if (ChangeName(ref name, newName))
            //{
            //    Console.WriteLine($"Your new name is {name}");
            //}
            //else
            //{
            //    Console.WriteLine(" New name cannot be empty or Null !");
            //}


            ////Summary:  


            Console.ReadLine();
        }

        ////-------------------------------------------------------------------------------------------------
        //// functions

        /* 
         * static void WelcomeMessage() //as the main function is static ,to use our function inside main we need object reference from static nature
        {
            Console.WriteLine("Welcome Aba");
        }
        */

        ////-------------------------------------------------------------------------------------------------
        //// void functions
        /*
         * static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 1, 2, 3 };

            foreach (var item in numbers)
            {
                Console.Write($"{item}\t");
            }
        }
        */
        ////-------------------------------------------------------------------------------------------------
        ////return type functions
        //// static string name = "Aba";


        // static string ReturnName()
        // {
        //     return "Lily";
        // }

        // static int ReturnAge()
        // {
        //     return 24;
        // }
        // static string ReturnNameAgePair()
        // {
        //     return $"{ReturnName()} - {ReturnAge()}";
        // }

        // static void PrintIntroduction()
        // {
        //     /* string name = ReturnName();
        //      int age = ReturnAge();

        //      string output = $"Hello my name is {name}  and my age is {age}";
        //      Console.WriteLine(output);
        //     */
        //     //// in one line
        //     Console.WriteLine($"Hello my name is {ReturnName()}  and my age is {ReturnAge()}");
        // }

        // static int ReadNumberFromConsole()
        // {            
        //      Console.Write("Enter a number: ");
        //      return Convert.ToInt32(Console.ReadLine());

        // }

        // static int[] CreateRandomArray()
        // {              
        //     return new int[3] { 0, 1, 2};
        // }


        ///* static void something()
        // {
        //     //conversion // you should separate them , because you cannot use one of them independently as they are pairs
        //     //calculation
        // }

        // static void conversion()
        // {

        // }

        // static void calculation()
        // {

        // }
        //*/

        ////-------------------------------------------------------------------------------------------------
        //// function parameters

        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //static int ReadInt(string message)
        //{
        //    Console.Write($"{message}: ");
        //    return Convert.ToInt32(Console.ReadLine());
        //}

        //static string ReadString(string message)
        //{
        //    Console.Write($"{message}: ");
        //    return Console.ReadLine();
        //}


        //static string UserDetails(string name, int age)
        //{
        //    return $"Hello my name is {name} and my age is {age}! ";
        //}

        ////-------------------------------------------------------------------------------------------------
        //// optional parameters


        //static int Add(int a = default , int b = default) // default = 0,  use [Optional] before parameters
        //{
        //    return a + b;
        //}
        //static void PrintName(string name = "Aba") //if no argument is entered, 'Aba' is used as a parameter
        //{
        //    {
        //        Console.WriteLine($"My name is {name}");
        //    }
        //}


        ////-------------------------------------------------------------------------------------------------
        //// named parameters

        //static void PrintDetails(string name, int age, string address)
        //{
        //    Console.WriteLine($"Name: {name}");
        //    Console.WriteLine($"Age: {age}");
        //    Console.WriteLine($"Address: {address}");
        //}

        ////-------------------------------------------------------------------------------------------------
        //// out parameters
        
        //static bool test(out int num) //you can have 2 different return values from one functions with out parameters
        //{
        //    //num = 5; // this variable is only available inside the function

        //    //return num;
        //    //or
        //    //return 5;
        //    num = 5;
        //    return true;
        //}

        ////rewriting TryParse() function
        //static bool tryParse(string s, out int result)
        //{
        //    result = 0;
        //    return true;
            
        //}

        //static bool FindInList(string s, List<string> list, out int index )
        //{
        //    index = -1; // 0 ->
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i].ToLower().Equals(s.ToLower()))
        //        {
        //            index = i;
        //        }
        //    }
            
        //    return  index > -1;

        //}

        ////-------------------------------------------------------------------------------------------------
        //// reference parameters
       
        //static void Assign(ref int num, ref string name) // for passing values to variables by reference which means original value changes according to assignment, not its copies are created
        //{
        //    num = 20;
        //    name = "Aba";
        //}

        //static bool ChangeName(ref string name , string newName)
        //{
        //    if (!string.IsNullOrEmpty(newName))
        //    {
        //        name = newName;
        //        return true;
        //    }
            
        //    return false;
            
        //}

    }


}
