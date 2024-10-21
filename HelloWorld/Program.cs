using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var letter = 'A';
            //// Format string
            //Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}",float.MinValue, float.MaxValue);

            //// Implicit type conversion
            //byte b = 1;
            //int a = b;
            //// explicit conversion
            //// CAST
            //int c = 256;
            //byte d = (byte)c;

            //// convert

            //string s = "1";
            //int i = Convert.ToInt32(s);
            //int j = int.Parse(s);

            //try
            //{

            //    var num = "1234";
            //    byte bytt = Convert.ToByte(num);
            //    Console.WriteLine(bytt);
            //}
            //catch (Exception)
            //{

            //    Console.WriteLine("errorrrrr");
            //}

            //// Non-Primitive Types
            //// Classes
            //// Access modifier      identifier
            //// Public        class   Person

            //// Object
            //// Person person = new Person();
            //// var person = new Person();

            //// Static modifier can be accessed from the Class it self directly like Person.Age(); not from the Object
            //// that to allocate a single instance in the memory for this static method


            //// struct vs Classes  =>   structures used for small classes with multiple instances like coordination x y or RGB.
            /// Structures are Value Types allocated in Stack automatically 
            /// where Classes and Reference Types allocated in heap manually with (new) operator and stayed for a while.
            /// memory management and allocation and garbage collection in CLR
            /// with pass by reference you point to the address of the allocated memory in the heap and store the address in the var
            /// 
            /// 
            //// Arrays

            //// declare array     set size   
            ////int[] numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var numbers = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(numbers[1]); // 2
            //Console.WriteLine(numbers[15]); // 0 default value /bool false /string "" 
            ////

            //// Strings   /// strings are Immutable XXX can't change it.
            //// String concatenation
            //string fName = "Kamal";
            //string lName = "Lahloh";
            //// with Class String you need to import the String class first.
            //String lName2 = "Lahloh";
            //Int32 i = 5; int j = 6; // same thing with import Int32

            //string name1 = fName + " " + lName;
            //string name2 = string.Format("{0} {1}", fName, lName);
            //string name3 = $"{fName} {lName}";

            //Console.WriteLine("name3: " + name3);

            //string list = string.Join(",", numbers);
            //Console.WriteLine(list);

            //// Escape characters \n \t \\ \' \"

            //// PATHS with Verbatim string ****
            ////string path = "c:\\desktop\\folder";
            //string path = @"c:\desktop\folder";

            //Console.WriteLine(path);


            //// Enums a set of name/value pairs of related (constants)  
            //// ** declare outside other method since it is a new type need to be defined at nameSpace level or Class level
            //Console.WriteLine(MyEnum.const1.ToString()); // const1
            //Console.WriteLine(MyEnum.const1); // const1  // Console.WriteLine apply ToString() to all its arguments
            //Console.WriteLine((int)MyEnum.const1); // 1


            //// casting Enums

            //var id = 2;
            //Console.WriteLine((MyEnum)id); // const2

            //var string1 = "const4";
            ////Enum.Parse(typeof(MyEnum), string1); // create an object need to be casted to our MyEnum
            ////var newEnum = (MyEnum)Enum.Parse(typeof(MyEnum), string1); // create an object need to be casted to our MyEnum

            ////Console.WriteLine(newEnum);

            //// solve casting error
            //if (Enum.TryParse<MyEnum>(string1, out var newEnum2) && Enum.IsDefined(typeof(MyEnum), newEnum2))
            //{
            //    Console.WriteLine(newEnum2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid enum value");
            //}


            // Conditional statements If else Switch ternary operator

            //var x = 1;
            //switch (x)
            //{
            //    case 0:
            //    case 1:
            //        // apply for both cases
            //        break;
            //    default:
            //        //
            //        break;
            //}
            static string validNum(int num)
            {
                return num > 0 && num < 10 ? "Valid" : "Invalid";
            }

            Console.WriteLine(validNum(1));
            Console.WriteLine(validNum(13));

            static int maxNum(int num1, int num2)
            {
                return Math.Max(num1, num2);
                //return num1 > num2 ? num1 : num2;
            }

            Console.WriteLine(maxNum(1, 2));
            Console.WriteLine(maxNum(13, 2));

            static string imagePosition(int height, int width)
            {
                return height > width ? "Portrait" : "Landscape";
            }

            Console.WriteLine(imagePosition(300, 500));
            Console.WriteLine(imagePosition(1300, 500));

            Console.WriteLine("Speed Limit: ");
            var speedRead = Console.ReadLine();
            int speedLimit = Convert.ToInt32(speedRead);

            Console.WriteLine("Car Speed: ");
            var speedRead2 = Console.ReadLine();
            int carSpeed = Convert.ToInt32(speedRead2);

            System.Console.WriteLine(speedLimitCalc(speedLimit, carSpeed));

            string speedLimitCalc(int speedLimit, int carSpeed)
            {
                if (carSpeed <= speedLimit) { return "Ok"; }

                int overSpeed = carSpeed - speedLimit;

                if (overSpeed < 60)
                    return Convert.ToString(Math.Ceiling((double)overSpeed / 5));
                else
                    return "License Suspended";
            }
        }
        //public enum MyEnum // basically it's a new Type 
        //{
        //    const1 = 1, // = 0, default values but not best practice since the order maybe changed later
        //    const2 = 2, // = 1,
        //    const3 = 3, // = 2,
        //}


    }
}
