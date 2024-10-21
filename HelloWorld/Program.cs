namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letter = 'A';
            // Format string
            Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}",float.MinValue, float.MaxValue);

            // Implicit type conversion
            byte b = 1;
            int a = b;
            // explicit conversion
            // CAST
            int c = 256;
            byte d = (byte)c;

            // convert

            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);

            try
            {

                var num = "1234";
                byte bytt = Convert.ToByte(num);
                Console.WriteLine(bytt);
            }
            catch (Exception)
            {

                Console.WriteLine("errorrrrr");
            }
        }
    }
}
