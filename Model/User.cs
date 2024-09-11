using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2307ca2.Model
{
    public class User
    {
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date {  get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"{Name} - {Email} - {Password}";
        }

    }
}
