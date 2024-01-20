namespace CRUDAPP.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; }
    }
}
