using System;
using System.Collections.Generic;

namespace Builder
{

    public interface IUser
    {
        string Name { get; }
        int Age { get; }
        string Address { get; }
    }

    /// <summary>
    /// Client shouldn't be able to create an object of User, Client can create an object of User using another builder Class
    /// </summary>
    public class User : IUser
    {
        private string name;
        private int age;
        private string address;

        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public string Address { get { return address; } }

        private User()
        {

        }


        public class UserBuilder
        {
            private readonly User user;

            public UserBuilder()
            {
                user = new User();
            }


            public UserBuilder WithName(string name)
            {
                user.name = name;
                return this;
            }

            public UserBuilder WithAge(int age)
            {
                user.age = age;
                return this;
            }

            public UserBuilder WithAddress(string address)
            {
                user.address = address;
                return this;
            }

            public User Build()
            {
                return user;
            }

        }

    }

    //public class MainApp
    //{


    //    public static void Main()
    //    {

    //        var obj = new User.UserBuilder().WithName("Ashish").WithAddress("Bangalore").Build();

    //        Console.WriteLine("sahjd");
    //        // User ashish = new User();
    //    }
    //}
}
