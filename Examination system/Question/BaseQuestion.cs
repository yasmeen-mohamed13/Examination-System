using Examination_system.Answer;
using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    public abstract class BaseQuestion
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public int RightAnswer { get; set; }
        public Answers[] Answer { get; set; }
        protected BaseQuestion()
        {
          Answer = new Answers[0];
        }
        protected BaseQuestion(string Header,string Body,int Mark, Answers[]Answers,int RightAnswer)
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
            this.Answer=Answers;
            this.RightAnswer = RightAnswer;
        }
        public void displayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}\n");
            Answers.DisplayAnswersArray(Answer);
            Console.WriteLine();
        }

    }
}
