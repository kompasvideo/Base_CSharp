var outerFn = () =>
{
    int x = 10;
    var innerFn = () => Console.WriteLine(++x);
    return innerFn;
};

var fn = outerFn();  // fn = innerFn, так как outerFn возвращяет innerFn
// вызываем innerFn
fn();   // 11
fn();   // 12
fn();   // 13

