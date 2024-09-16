namespace _09_01_02_ConstantPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var message = "helllo";

            // проверяем, соответствует ли значение message строке "hello"
            if(message is "hello")
            {
                Console.WriteLine("hello");
            }
        }
    }
}
