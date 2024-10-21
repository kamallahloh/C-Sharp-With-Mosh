namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int Number = 1;
            const float b = 2.321f;

            var @var = "reserved";

            var strFirstName = "Hungarian notaion don't use";
            const string Pascal = "pascal case for constants";

            // Primative types:
            // byte short int long 
            // float => 1.23f // double default date type for numbers // decimal => 1.23m
            // char 
            // bool

            // non primative
            // String Array Enum Class

            //////////////
            ///
            // over flowing

            checked
            {
                byte numb = 255; // max value
                numb = (byte)(numb + 1); // == 0 System.OverflowException: 'Arithmetic operation resulted in an overflow.'

                Console.WriteLine(numb);
            }



        }
    }
}
