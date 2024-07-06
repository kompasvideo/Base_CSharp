Person person = new Person();

((ISchool)person).Study();
((IUniversity)person).Study();

class Person : ISchool, IUniversity
{
    //public void Study() => Console.WriteLine("Учёба в школе или университете");
    void ISchool.Study() =>  Console.WriteLine("Учёба в школе");
    void IUniversity.Study() =>  Console.WriteLine("Учёба в университете");
}
interface ISchool
{
    void Study();
}
interface IUniversity
{
    void Study();
}
