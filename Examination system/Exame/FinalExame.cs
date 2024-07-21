using Examination_system.Helper;
using Examination_system.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exame
{
    internal class FinalExame : BaseExame
    {
        public BaseQuestion[]? Questions { get; set; }
        public FinalExame()
        {
  
        }
        public FinalExame(int Time,int NumOfQuestions, BaseQuestion[] questions) : base(Time, NumOfQuestions)
        {
            Questions = questions;
        }
        public override void Display()
        {
            ShowTimeAndNumOfQuestions(Time, NumOfQuestions);
            DisplayQuestionsArray.DisplayQuestionArray(Questions??new BaseQuestion[0], true);
        }
    }
}
