Operation operation1 = Add;
Operation operation = new Operation(Add);

int Add(int x, int y) => x + y;

delegate int Operation(int x, int y);