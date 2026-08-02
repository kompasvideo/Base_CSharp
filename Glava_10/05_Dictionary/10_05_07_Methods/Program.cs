// условная телефонная книга
var phonebook = new Dictionary<string, string>();

// добавляем элемент: ключ - номер телефона, значение - имя абонента
phonebook.Add("+123456", "Tom");
// альтернативное добавление
// phonebook["+123456"] = "Tom";

// Проверка наличия
var phoneExist1 = phonebook.ContainsKey("+123456");  // true
Console.WriteLine($"+123456 : {phoneExist1}");
var phoneExist2 = phonebook.ContainsKey("+567456");  // false
Console.WriteLine($"+567456 : {phoneExist2}");
var abonentExist1 = phonebook.ContainsValue("Tom"); // true
Console.WriteLine($"Tom : {abonentExist1}");
var abonentExist2 = phonebook.ContainsValue("Bob");  // false
Console.WriteLine($"Bob : {abonentExist2}");

// удаление элемента
phonebook.Remove("+123456");

// проверяем количество элементов после удаления
Console.WriteLine($"Count : {phonebook.Count}");