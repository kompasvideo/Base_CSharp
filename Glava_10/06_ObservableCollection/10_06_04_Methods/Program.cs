using System.Collections.ObjectModel;

var people = new ObservableCollection<string>();

// добавляем элемент
people.Add("Bob");
// вставляем элемент по индексу 0
people.Insert(0, "Tom");

// проверка наличия индекса
bool bobExists = people.Contains("Bob");            // true
Console.WriteLine($"Bob exists: {bobExists}");
bool mikeExists = people.Contains("Mike");          // False
Console.WriteLine($"Mike's exists: {mikeExists}");

// удаляем элемент
people.Remove("Tom");
// удаляем элемент по индексу 0
people.RemoveAt(0);
Console.WriteLine($"Count: {people.Count}");