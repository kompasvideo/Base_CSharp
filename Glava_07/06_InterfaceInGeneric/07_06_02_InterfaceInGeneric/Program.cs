IUser<int> user1 = new User<int>(6789);
Console.WriteLine(user1.Id); // 6789

IUser<string> user2 = new User<string>("12345");
Console.WriteLine(user2.Id);

IUser<int> user3 = new IntUser(2345);
Console.WriteLine(user3.Id);    //2345

IntUser user4 = new IntUser(9840);
Console.WriteLine(user4.Id);    // 9840

interface IUser<T>
{
    T Id { get; }
}
class User<T> : IUser<T>
{
    public T Id { get; }
    public User(T id) => Id = id;
}
class IntUser : IUser<int>
{
    public int Id { get; }
    public IntUser(int id) => Id = id;
}