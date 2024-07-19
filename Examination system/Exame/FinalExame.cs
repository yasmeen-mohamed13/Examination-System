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
        public TrueFalseQuestion[] TrueFalseQuestions { get; set; }
        public MCQQuestion[] MCQQuestions { get; set; }
        public FinalExame()
        {
            TrueFalseQuestions = new TrueFalseQuestion[0];
            MCQQuestions = new MCQQuestion[0];
        }
        public FinalExame(int Time,int NumOfQuestions, TrueFalseQuestion[] trueFalseQuestions ,MCQQuestion[] mCQQuestions) : base(Time, NumOfQuestions)
        {
            TrueFalseQuestions = trueFalseQuestions;
            MCQQuestions = mCQQuestions;
        }
        public override void Display()
        {
            int studentChoose;
            ShowTimeAndNumOfQuestions(Time,NumOfQuestions);
            Console.WriteLine("What Do You Prefear To Start With : 1- True of False \n2- MSQ");
            while (!int.TryParse(Console.ReadLine(), out studentChoose) || studentChoose > 2 || studentChoose == 0)
            {
                Console.WriteLine("Please Enter Valid Choose 1 or 2");
            }

            Console.Clear();

            if (studentChoose==1)
            {
                DisplayQuestionsArray.DisplayTrueFalseArray(TrueFalseQuestions);
                DisplayQuestionsArray.DisplayMCQArray(MCQQuestions);
            }
            else
            {
                DisplayQuestionsArray.DisplayMCQArray(MCQQuestions);
                DisplayQuestionsArray.DisplayTrueFalseArray(TrueFalseQuestions);
            }
            
        }
    }
}
