using System.Collections.ObjectModel;

var people = new ObservableCollection<string>
{
    "Tom", "Bob", "Sam"
};

// изменяем первый элемент
people[0] = "Tomas";
Console.WriteLine(people[0]); // Tomas