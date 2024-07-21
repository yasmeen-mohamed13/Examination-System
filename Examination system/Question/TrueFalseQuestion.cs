using Examination_system.Answer;
using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    public class TrueFalseQuestion :BaseQuestion
    {
        public TrueFalseQuestion()
        {

        }
        public TrueFalseQuestion(string Header, string Body, int Mark, Answers[] Answers,int RightAnswer) : base(Header, Body, Mark, Answers, RightAnswer)
        {

        }
        public static TrueFalseQuestion CreateQuestion(int index)
        {
            Console.WriteLine($"Enter the True or False Question {index + 1}");

            string body = Validations.ValidateStrings();
            Console.Clear();

            Console.WriteLine("Enter the Mark of this question");
            int mark = Validations.ValidateNumbers();
            Console.Clear();

            Answers[] answerstruefalse = Answers.CreateTrueFalseAnswer();

            Console.WriteLine("Enter the Number of Right Answer for this question : 1- True , 2- False");
            int rightanswer = Validations.ValidateRightAnswerNumber(true);
            Console.Clear();

            return new TrueFalseQuestion()
             {
                 Header = $"True Or False Question {index + 1}",
                 Body = body,
                 Mark = mark,
                 Answer = answerstruefalse,
                 RightAnswer = rightanswer
             };
        }
        public static TrueFalseQuestion[] CreateQuestionsArray(int size)
        {
            TrueFalseQuestion[] truefalseQuestions = new TrueFalseQuestion[size];
            if (size > 0)
            {
                for (int i = 0; i < truefalseQuestions.Length; i++)
                {
                    truefalseQuestions[i] = CreateQuestion(i);
                }
            }
            return truefalseQuestions;
        }

    }
}
