List<string> people = new List<string>();
List<string> people2 = new List<string>() { "Tom", "Bob", "Sam"};

var people3 = new List<string>() {"Tom", "Bob", "Sam" };
var emloyees3 = new List<string>(people3);

var people4 = new List<string>() { "Tom", "Bob", "Sam" };
var employees4 = new List<string>(people4) { "Mike" };

List<string> people5 = ["Tom", "Bob", "Sam"];
List<string> employees5 = []; // пустой список

Console.WriteLine("Hello, World!");