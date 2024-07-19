using Examination_system.Helper;
using Examination_system.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exame
{
    internal class PracticalExame : BaseExame
    {
        public MCQQuestion[] MCQQuestions { get; set; }
        public PracticalExame()
        {
            MCQQuestions = new MCQQuestion[0];
        }
        public PracticalExame(int Time,int NumOfQuestions, MCQQuestion[]mCQQuestions):base(Time,NumOfQuestions)
        {
            MCQQuestions=mCQQuestions;
        }
        public override void Display()
        {
            ShowTimeAndNumOfQuestions(Time, NumOfQuestions);
           DisplayQuestionsArray.DisplayMCQArray(MCQQuestions);
        }
    }
}
