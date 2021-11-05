using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Quiz
    {
        public Quiz()
        {
            QuizQuestions = new HashSet<QuizQuestion>();
            Respondents = new HashSet<Respondent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
        public virtual ICollection<Respondent> Respondents { get; set; }
    }
}
