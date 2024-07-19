using Examination_system.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    abstract class BaseQuestion
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public Answers[] Answers { get; set; }

        protected BaseQuestion()
        {
            Answers = new Answers[0];
        }
        protected BaseQuestion(string Header,string Body,int Mark, Answers[]answers)
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
            this.Answers=answers;
        }
    }
}
