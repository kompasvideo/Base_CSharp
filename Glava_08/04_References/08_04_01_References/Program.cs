int x = 5;
ref int xRef = ref x;
Console.WriteLine(x);       // 5
xRef = 125;
Console.WriteLine(x);       // 125
x = 625;
Console.WriteLine(xRef);    // 625
