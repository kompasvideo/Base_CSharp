namespace _06_01_03_My_DelegateInMain
{
    delegate void Message();
    internal class Program
    {
        //delegate void Message();
        static void Main(string[] args)
        {
            Message mes;
            mes = Hello;
            mes();

            void Hello() => Console.WriteLine("Hello, World!");
        }
    }
}
