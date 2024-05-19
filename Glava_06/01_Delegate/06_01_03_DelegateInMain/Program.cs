class Program
{
    delegate void Message();  // 1. Объявляем делегат
    static void Main()
    {
        Message mes;    // 2. Создаём переменную делегата 
        mes = Hello;    // 3. Присваиваем этой переменной адрес вызова
        mes();          // 4. Вызов метода

        void Hello() =>  Console.WriteLine("Hello, World!");
    }        
}
