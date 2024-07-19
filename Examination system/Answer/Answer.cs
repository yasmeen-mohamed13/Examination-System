using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Answer
{
    internal class Answer
    {
        public int Id { get; set; }
        public string? AnswerText { get; set; }

        public Answer()
        {

        }
        public Answer(int Id, string AnswerText)
        {
            this.Id = Id;
            this.AnswerText = AnswerText;
        }
    }
}
