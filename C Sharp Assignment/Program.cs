using System;
using System.Text;

namespace C_Sharp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------assignment 1 --------------------------
            //--------------------------------------------------------
            //call by value
            int a = 1, b = 5;
            CallByValueTest(a, b);
            Console.WriteLine("call by value: " + a + " " + b);
            //call by reference
            StringBuilder word = new StringBuilder("Hello", 50);
            CallByReferenceTest(word);
            Console.WriteLine("call by reference: " + word.ToString());
            //Write a method to take 3 arguments and print them by using interpolation
            AnonymousType();
            //Write a method to calculate how many hours we have until next year.
            Console.WriteLine($"There are {HowManyHoursToNextYear()} hours to 2021");
            //using multi line to write your first name, last name and email
            Console.WriteLine(information);
            //what is the difference between var and dynamic
            var aVar = "word";
            //aVar = 100; //the compiler will complain due to the var type cannot be changed in runtime
            dynamic aDynamic = "word";
            aDynamic = 123;//the dynamic type can be changed in runtime

            //-----------------assignment 1 --------------------------
            //-----------------assignment 2---------------------------

            //By using stringbuilder Append a sentence by using your fname,lastname and email
            StringbuilderAppend();
            //Create 2 partial class (optional structure)
            PClass person = new PClass();
            person.name = "Tom";
            person.age = 10;
            //Use static methods and static fields in a static class to calculate the area of a circle.
            Console.WriteLine(CircleArea.Area(CircleArea.radium = 5));
            //Create a 2D JaggedArray and 3D JaggedArray with optioanl type
            //and fill them with values and print them in the console.
            int[][,] jaggedArray1 = new int[2][,]
            {
                new int[,] { {1,2,3}, {5,5,7} },
                new int[,] { {0,2}, {4,6} },
            };

            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                for (int j = 0; j < jaggedArray1[i].GetLength(0); j++)
                {
                    for (int q = 0; q < jaggedArray1[i].GetLength(1); q++)
                    {
                        Console.WriteLine(jaggedArray1[i][j, q]);
                    }
                }
            }


            int[][,,] jaggedArray2 = new int[2][,,]
            {
                new int[,,] { { { 1, 3 }, { 5, 7 } }, { { 9, 11}, { 13, 15 } } },
                new int[,,] { { { 0, 2 }, { 4, 6 } }, { { 8, 10 }, { 12, 14 } } }
            };
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].GetLength(0); j++)
                {
                    for (int q = 0; q < jaggedArray2[i].GetLength(1); q++)
                    {
                        for (int p = 0; p < jaggedArray2[i].GetLength(2); p++)
                        {
                            Console.WriteLine(jaggedArray2[i][j, q, p]);
                        }
                    }
                }
            }
            //Create indexer optional structure to have access to the private data
            //in the class.(optional structure)
            Person person1 = new Person();
            person1[0] = "personiName";
            person1[1] = "123456";
            //Create a method that takes tuple as an input and 
            //returns tuple as the output...(optional structure)
            var tp = Tuple.Create(1, 2, 3);
            TupleMethod(tp); 
        }


        //-----------------assignment 1 --------------------------
        //--------------------------------------------------------
        public static void AnonymousType()
        {
            //Create an anonymous type that contains 3 fields and name it shape
            var shape = new { Color = "White", Size = "XL", Model = "007" };
            Console.WriteLine($"The {shape.Model} {shape.Size} is {shape.Color} ");
        }

        public static void CallByValueTest(int x, int y)
        {
            x = x + y;
        }
        public static void CallByReferenceTest(StringBuilder str)
        {
            str.Append(" World");
        }

        //Creat a struct Name is as BankAccount which has 2 fields
        struct BankAccount
        {
            //Create an Enum -> 3 types
            public enum typeOfAccount
            {
                checking,
                saving,
                lineOfCredit
            };
            public float depositAmount;
        }
        //Write a method to calculate how many hours we have until next year.
        static double HowManyHoursToNextYear()
        {
            DateTime dt1 = DateTime.Now;
            DateTime dt2 = new DateTime(2021, 1, 1);
            TimeSpan ts = dt2 - dt1;
            return ts.TotalHours;
        }

        //using multi line to write your first name, last name and email
        static String information = @"Zhanzhou
Ta 
tazhanzhou@outlook.com
";

        //-----------------assignment 1 --------------------------
        //-----------------assignment 2 ---------------------------

        //By using stringbuilder Append a sentence by using your fname,lastname and email
        static void StringbuilderAppend()
        {
            StringBuilder sb = new StringBuilder("Ta");
            sb.Append(" Zhanzhou");
            sb.Append(" tazhanzhou@outlook.com");
            Console.WriteLine(sb.ToString());
        }

        //Create a method that takes tuple as an input and 
        //returns tuple as the output...(optional structure)
        public static Tuple<int, int, int> TupleMethod(Tuple<int, int, int> tp)
        {
            return Tuple.Create(tp.Item1*2, tp.Item2*3, tp.Item3*4); 
        }
    }

}
