using System.Collections;

string[] people = { "Tom", "Sam", "Bob" };
IEnumerator peopleEnumerator = people.GetEnumerator();
while (peopleEnumerator.MoveNext())
{
    string item = (string)peopleEnumerator.Current;
    Console.WriteLine(item);
}