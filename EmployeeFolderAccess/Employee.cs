namespace ProxyDesignPattern
{
    internal class Employee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Employee(string Username, string Password, string Role)
        {
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
        }
    }
}