var people = new LinkedList<string>();
people.AddLast("Tom");      // вставляем узел со значением Tom на последнее место
                            //так как в списке нет узлов, то последнее будет также и первым
people.AddFirst("Bob");     // вставляем узел со значением Bob на первое место

// вставляем после первого узла новый узел со значением Mike
if(people.First != null) people.AddAfter(people.First, "Mike");

// теперь у нас список имеет следующую последовательность: Bob Mike Tom
foreach(var person in people) Console.WriteLine(person);