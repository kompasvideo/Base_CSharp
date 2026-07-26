var people = new Stack<string>();
people.Push("Tom");
// people + {"Tom"}
people.Push("Sam");
// people + {"Tom", 'Sam"}
people.Push("Bob");
// people + {"Tom", "Sam", "Bob"}

// получаем первый элемент из стека без его удаления
string headPerson = people.Peek();
Console.WriteLine(headPerson);      // Bob

string person1 = people.Pop();
// people + {"Tom", 'Sam"}
Console.WriteLine(person1); // Bob

string person2 = people.Pop();
// people + {"Tom"}
Console.WriteLine(person2); // Sam

string person3 = people.Pop();
// people + {}
Console.WriteLine(person3); // Tom