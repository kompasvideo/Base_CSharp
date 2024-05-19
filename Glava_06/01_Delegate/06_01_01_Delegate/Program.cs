Message mes;    // 2. Создаём переменную делегата
mes = Hello;    // 3. Присваиваем этой преременной адресс метода
mes();          // 4. Вызываем метод

void Hello() => Console.WriteLine("Hello, World!");

delegate void Message(); // 1. Объявляем делегат