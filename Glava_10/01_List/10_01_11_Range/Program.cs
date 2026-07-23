List<string> people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob"};

// получаем диапазон со второго по четвертый элемент
var range = people.GetRange(1, 3);
// range = {"Tom", "Mike", "Sam"};

// копируем в массив первые три элемента
string[] partOfPeople = new string[3];
people.CopyTo(0, partOfPeople, 0, 3);
// partOfPeople = { "Eugene", "Tom", "Mike"};