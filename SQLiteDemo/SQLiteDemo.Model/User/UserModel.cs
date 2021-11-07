namespace SQLiteDemo.Model.User
{
    public class UserModel : IUserModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}";
        public int ID { get; set; }
    }
}
