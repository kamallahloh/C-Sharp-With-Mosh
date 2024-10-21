using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    internal class Program
    {
        static int Main(string[] args)
        {
            // Arrays and Lists and (multidimensional array) 

            var numbers = new int[5] { 11, 2, 53, 24, 05 }; // object initialization syntax

            // rec or jagged
            // 2D array
            // row , col
            var rectangular = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 11, 12, 13, 14, 15 }, { 21, 22, 23, 24, 25 } };
            // 3D array
            // row , col , dep
            var zArray = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            // jagged
            var jagged = new int[3][] { new int[2] { 1, 2 }, new int[4] { 2, 3, 4, 5 }, new int[3] { 6, 7, 8 } };
            // XXX var jagged = new int[3][] { { 1, 2 },  { 2, 3, 4, 5 }, { 6, 7, 8 } };
            //Console.WriteLine(rectangular[2, 2]); // 23
            //Console.WriteLine(zArray[1, 0, 1]); // 6
            //Console.WriteLine(jagged[1][3]); // 5


            // Array Methods

            // length property no () 
            // indexOf(array,value); 
            Console.WriteLine("Numbers");
            Array.IndexOf(numbers, 11); // 0
            foreach (var number in numbers)
                Console.Write(number + " "); // 11 2 53 24 5
            // Clear(array,index,length); default set int to 0 // bool false // str or others to null
            Console.WriteLine("");
            Console.WriteLine("Clear:");
            //Array.Clear(numbers, 0, 2); // 0 0 53 24 5
            foreach (var number in numbers)
                Console.Write(number + " ");
            // copy(source,dist,numberOfCoppied);
            var otherArray = new int[3];
            Console.WriteLine("");
            Console.WriteLine("copy:"); // 0 0 53
            Array.Copy(numbers, otherArray, 3);
            foreach (var number in otherArray)
                Console.Write(number + " ");
            //

            Console.WriteLine("");
            Console.WriteLine("modify the copy:");
            otherArray[0] = 33;
            Console.WriteLine("");
            Console.WriteLine("original"); // 0 0 53 24 5 !!!!!!!!!!!!!! immutable
            foreach (var number in numbers)
                Console.Write(number + " ");
            Console.WriteLine("");
            Console.WriteLine("the copy:"); // 33 0 53   
            foreach (var number in otherArray)
                Console.Write(number + " ");


            // sort();
            Array.Sort(numbers);
            Console.WriteLine("");
            Console.WriteLine("sort");
            foreach (var number in numbers)
                Console.Write(number + " "); // a,b => a-b 2 5 11 24 53
            Console.WriteLine("");

            // reverse()   // ALL METHODS are static



            // LISTS not fix size but dynamic

            var list = new List<int>() { 1, 2, 3, 4 };

            // Add() AddRange() Remove() RemoveAt() IndexOf() Contains() Count;

            list.Add(1);
            list.AddRange(numbers); // add IEnumerable<int> I interface Enumerable instance of array or list

            list.IndexOf(1); // index of number 1 = 0
            list.LastIndexOf(1); // 4

            Console.WriteLine(list.Count);

            list.RemoveAt(0);
            list.Remove(2);
            list.RemoveAll(x => x == 4);
            list.Clear();
            Console.WriteLine(list.Count);


        }

    }
}
