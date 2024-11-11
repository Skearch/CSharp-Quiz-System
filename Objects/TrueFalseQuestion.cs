using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Quiz_System.Objects
{
    public class TrueFalseQuestion
    {
        public string Question { get; set; }
        public bool CorrectAnswer { get; set; }

        public TrueFalseQuestion(string question, bool correctAnswer)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
        }
    }
}
