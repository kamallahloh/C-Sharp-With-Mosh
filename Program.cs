namespace CSharpWithMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SCOPE

            byte number;
            number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char charachter = 'A';
            string firstName = "Kamal";
            bool isWorking = true;
            //cw
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(isWorking);

            var variable = 55;

            //
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);

            //
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            //
            const float Pi = 3.14f;

            Pi = 5.5;




        }
    }
}
