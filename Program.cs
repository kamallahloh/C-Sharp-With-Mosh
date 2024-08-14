namespace CSharpWithMosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type conversion

            // implicit (no data loss)
            byte b = 1;
            int i = b;
            float x = i;

            // reverse not allowed since data will be lost. Won't compile

            // explicit
            int s = 300;
            byte s1 = (byte)s;

            // non-compatible

            string st = "5";
            int j = Convert.ToInt32(st);

            int z = int.Parse(st);

            // ToByte()
            // ToInt64()


            byte bs = 1;
            int ii = 300;
            byte bb = (byte)ii;

            Console.WriteLine(bb); //300 =byte 44



            
            try
            {
                var number = "1234";
                int iii = int.Parse(number); // or Convert.ToInt32()
                //byte bbb = Convert.ToByte(number); // or Convert.ToInt32() /// Error OverflowException
                //Console.WriteLine(bbb);


                var str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR in convert");
              
            }
            
            
           


        }
    }
}
