using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class QuestionResponse
    {
        public int Id { get; set; }
        public string Response { get; set; }
        public int RespondentId { get; set; }
        public int QuizQuestionId { get; set; }

        public virtual QuizQuestion QuizQuestion { get; set; }
        public virtual Respondent Respondent { get; set; }
    }
}
