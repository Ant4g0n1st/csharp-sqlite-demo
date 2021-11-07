namespace SQLiteDemo.Model.User
{
    public interface IUserModel
    {
        string Name { get; set; }
        string LastName { get; set; }
        string FullName { get; }
        int ID { get; set; }
    }
}
