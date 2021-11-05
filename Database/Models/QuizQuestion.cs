using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class QuizQuestion
    {
        public QuizQuestion()
        {
            QuestionResponses = new HashSet<QuestionResponse>();
        }

        public int Id { get; set; }
        public string Question { get; set; }
        public int QuizId { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<QuestionResponse> QuestionResponses { get; set; }
    }
}
