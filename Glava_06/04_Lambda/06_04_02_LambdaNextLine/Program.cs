Message hello = () =>
{
    Console.Write("Hello, ");
    Console.WriteLine("World!");
};
hello();

delegate void Message();