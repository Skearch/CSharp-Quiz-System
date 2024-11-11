using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Quiz_System.Objects
{
    public class MultipleChoiceQuestion
    {
        public string Question { get; set; }
        public List<string> Choices { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public MultipleChoiceQuestion(string question, List<string> choices, int correctAnswerIndex)
        {
            Question = question;
            Choices = choices;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
