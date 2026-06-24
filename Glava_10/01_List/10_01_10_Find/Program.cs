var people = new List<string>(){ "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

var constantBob = people.Contains("Bob");  // true
var constantBill = people.Contains("Bill"); // false

// проверяем, есть ли в списке строки с длиной 7 символов
var existsLength7 = people.Exists(x => x.Length == 7);

// получаем первый элемент с длиной 3 символа
var firstWithLength3 = people.Find(x => x.Length == 3);

// получаем последний элемент с длиной 3 символа
var lastWithLength3 = people.FindLast(x => x.Length == 3);

// получаем все элементы с длиной в 3 символа в виде списка
List<string> peopleWithLength3 = people.FindAll(x => x.Length == 3);
// peopleWithLength3 { "Tom", "Bob", "Sam"}