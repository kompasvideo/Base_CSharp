var people = new Queue<string>();

// добавляем элементы
people.Enqueue("Tom");      // people = {"Tom"}

// удаляем элементы
var success1 = people.TryDequeue(out var person1);   // success1 = true
if (success1)  Console.WriteLine(person1);

var success2 = people.TryDequeue(out var person2);   // success2 = false
if (success2)  Console.WriteLine(person2);