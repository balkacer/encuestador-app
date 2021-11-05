using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class User
    {
        public User()
        {
            Quizzes = new HashSet<Quiz>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Quiz> Quizzes { get; set; }
    }
}
