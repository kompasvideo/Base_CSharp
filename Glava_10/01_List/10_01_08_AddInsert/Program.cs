List<string> people = new List<string>() { "Tom" };

people.Add("Bob"); // добавление элемента
// people = {"Tom","Bob")

people.AddRange(new []{"Sam", "Alice"}); // добавляем массив
// people = {"Tom","Bob", "Sam", "Alice")
// также можно добавить другой список
// people.AddRange(new List<string>(){"Sam", "Alice"});

people.Insert(0, "Eugene"); // вставляем на первое место
// people = {"Eugene", "Tom","Bob", "Sam", "Alice")

people.InsertRange(1, new string[] {"Mike", "Kate"}); // вставляем массив с индекса 1
// people = {"Eugene", "Mike", "Kate", "Tom","Bob", "Sam", "Alice")

// также можно было бы добавить другой список
// people.InsertRange(1, new List<string> {"Mike", "Kate"}); 
