using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Respondent
    {
        public Respondent()
        {
            QuestionResponses = new HashSet<QuestionResponse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int QuizId { get; set; }

        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<QuestionResponse> QuestionResponses { get; set; }
    }
}
