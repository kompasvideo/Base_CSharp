Operation sum = (x,y) => Console.WriteLine($"{x} + {y} = {x + y}");
sum(1, 2);      // 1 + 2 = 3
sum(22, 14);    // 22 + 14 = 36

delegate void Operation(int x, int y);