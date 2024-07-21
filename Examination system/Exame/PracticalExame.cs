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
        public BaseQuestion[]? Questions { get; set; }
        public PracticalExame()
        {
            MCQQuestions = new MCQQuestion[0];
        }
        public PracticalExame(int Time,int NumOfQuestions, BaseQuestion[]questions):base(Time,NumOfQuestions)
        {
            Questions=questions;
        }  
        public override void Display()
        {
            ShowTimeAndNumOfQuestions(Time, NumOfQuestions);
            DisplayQuestionsArray.DisplayQuestionArray(Questions ?? new BaseQuestion[0], false);
            Console.Clear();
            DisplayExameWithRightAnswer();
        }
        public void DisplayExameWithRightAnswer()
        {
            if (Questions?.Length > 0)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    Questions[i].displayQuestion();
                    Console.WriteLine("Enter Your Answer ");
                    Console.WriteLine($"The Right Answer is : {Questions[i].RightAnswer}");
                    Console.WriteLine("=======================================================");
                }
            }
        }
    }
}
