using System.Collections.ObjectModel;

var people = new ObservableCollection<string>()
{
    "Tom", "Bob", "Sam"
};
foreach (var person in people)
{
    Console.WriteLine(person);
}

Console.WriteLine();
for (int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i]);
}