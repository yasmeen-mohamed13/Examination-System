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
        public static void DisplayQuestionArray(BaseQuestion[] questions,bool flag)
        {
            //if true = final exame
            if (flag)
            {
                int TotalGrade = 0;
                if (questions.Length>0)
                {
                    for (int i=0;i<questions.Length;i++)
                    {
                        questions[i].displayQuestion(i);
                        int userAnswer;

                        Console.ForegroundColor = ConsoleColor.Green;

                        if (questions[i].Header?.CompareTo("mcq")==0)
                        {
                            userAnswer = Validations.ValidateRightAnswerNumber(false);
                        }
                        else
                        {
                            userAnswer = Validations.ValidateRightAnswerNumber(true);
                        }
                        TotalGrade += CalculateGrade(userAnswer, questions[i].RightAnswer, questions[i].Mark);
                    Console.ResetColor();
                        Console.WriteLine("==============================================");
                    }

                }
                Console.WriteLine($"Your Grade is : {TotalGrade}");
            }
            // false = practical exame
            else
            {
                if (questions.Length>0)
                {
                    for (int i = 0; i < questions.Length; i++)
                    {
                        questions[i].displayQuestion(i);
                        Console.WriteLine($"Mark Of This Question : {questions[i].Mark}");
                        Console.WriteLine();
                        Console.WriteLine("Enter Your Answer ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        int userAnswer = Validations.ValidateRightAnswerNumber(false);
                        Console.ResetColor();

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
