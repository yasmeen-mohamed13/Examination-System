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
            DisplayQuestionsArray.DisplayQuestionArray(null, MCQQuestions, false);
            Console.Clear();
            DisplayExameWithRightAnswer();
        }
        public void DisplayExameWithRightAnswer()
        {
            if (MCQQuestions.Length > 0)
            {
                for (int i = 0; i < MCQQuestions.Length; i++)
                {
                    MCQQuestions[i].displayQuestion();
                    Console.WriteLine("Enter Your Answer ");
                    Console.WriteLine($"The Right Answer is : {MCQQuestions[i].RightAnswer}");
                    Console.WriteLine("=======================================================");
                }
            }
        }
    }
}
