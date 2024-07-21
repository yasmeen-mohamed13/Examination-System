using Examination_system.Answer;
using Examination_system.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Helper
{
    public static class DisplayQuestionsArray
    {
        public static void DisplayQuestionArray(TrueFalseQuestion[]? trueFalseQuestions, MCQQuestion[]? mCQQuestions,bool flag)
        {
            //if true = final exame
            if (flag)
            {
                int TotalGrade = 0;
                if (trueFalseQuestions?.Length>0)
                {
                    for (int i = 0; i < trueFalseQuestions.Length; i++)
                    {
                        trueFalseQuestions[i].displayQuestion();
                        Console.WriteLine("Enter Your Answer : ");
                        int userAnswer = Validations.ValidateRightAnswerNumber(true);
                        TotalGrade += CalculateGrade(userAnswer, trueFalseQuestions[i].RightAnswer, trueFalseQuestions[i].Mark);
                        Console.WriteLine("==============================================");
                    }
                }
                if(mCQQuestions?.Length>0)
                {
                    for (int i = 0; i < mCQQuestions.Length; i++)
                    {
                        mCQQuestions[i].displayQuestion();
                        Console.WriteLine("Enter Your Answer : ");
                        int userAnswer = Validations.ValidateRightAnswerNumber(true);
                        TotalGrade += CalculateGrade(userAnswer, mCQQuestions[i].RightAnswer, mCQQuestions[i].Mark);
                        Console.WriteLine("==============================================");
                    }
                }
                Console.WriteLine($"Your Grade is : {TotalGrade}");
            }
            // false = practical exame
            else
            {
                if (mCQQuestions?.Length>0)
                {
                    for (int i = 0; i < mCQQuestions.Length; i++)
                    {
                        mCQQuestions[i].displayQuestion();
                        Console.WriteLine($"Mark Of This Question : {mCQQuestions[i].Mark}");
                        Console.WriteLine();
                        Console.WriteLine("Enter Your Answer ");
                        int userAnswer = Validations.ValidateRightAnswerNumber(false);
                        Console.WriteLine("=======================================================");
                    }
                }
            }
        }
        public static int CalculateGrade(int userAnswer, int rightAnswer, int mark)
        {
            if (userAnswer == rightAnswer)
            {
                return mark;
            }
            return 0;
        }

    }
}
