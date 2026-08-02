using System.Collections.ObjectModel;

ObservableCollection<string> people = new ObservableCollection<string>();

var people2 = new ObservableCollection<string>(new string[]{"Tom", "Bob", "Sam"});

var people3 = new ObservableCollection<string>
{
    "Tom", "Bob", "Sam"
};

Console.WriteLine("Hello, World!");