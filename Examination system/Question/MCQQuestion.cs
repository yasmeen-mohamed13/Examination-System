using Examination_system.Answer;
using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    internal class MCQQuestion : BaseQuestion
    {
        public MCQQuestion()
        {
            
        }
        public MCQQuestion(string Header,string Body, int Mark, Answers[]Answers,int RightAnswer) :base(Header,Body,Mark,Answers, RightAnswer)
        {
            
        }

    }
}
