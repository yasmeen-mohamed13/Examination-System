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
        public TrueFalseQuestion[]? TrueFalseQuestions { get; set; }
        public MCQQuestion[]? MCQQuestions { get; set; }
        public FinalExame()
        {
  
        }
        public FinalExame(int Time,int NumOfQuestions, TrueFalseQuestion[] trueFalseQuestions ,MCQQuestion[] mCQQuestions) : base(Time, NumOfQuestions)
        {
            TrueFalseQuestions = trueFalseQuestions;
            MCQQuestions = mCQQuestions;
        } 
        public FinalExame(int Time,int NumOfQuestions, TrueFalseQuestion[] trueFalseQuestions) : base(Time, NumOfQuestions)
        {
            TrueFalseQuestions = trueFalseQuestions;
        }
        public FinalExame(int Time,int NumOfQuestions, MCQQuestion[] mCQQuestions) : base(Time, NumOfQuestions)
        {
            MCQQuestions = mCQQuestions;
        }
        public override void Display()
        {
            ShowTimeAndNumOfQuestions(Time, NumOfQuestions);
            DisplayQuestionsArray.DisplayQuestionArray(TrueFalseQuestions, MCQQuestions, true);
        }
    }
}
