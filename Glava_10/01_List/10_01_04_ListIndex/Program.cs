var people = new List<string>() { "Tom", "Bob", "Sam" };

string firstPerson = people[0]; // получаем первый элемент
Console.WriteLine(firstPerson); // Tom
people[0] = "Mike";
Console.WriteLine(people[0]); // Mike