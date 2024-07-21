using Examination_system.Answer;
using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    public class MCQQuestion : BaseQuestion
    {
        public MCQQuestion()
        {
            
        }
        public MCQQuestion(string Header,string Body, int Mark, Answers[]Answers,int RightAnswer) :base(Header,Body,Mark,Answers, RightAnswer)
        {
            
        }

        public static MCQQuestion CreateQuestion(int index)
        {
            Console.WriteLine($"Enter the MCQ Question {index + 1}");

            string body = Validations.ValidateStrings();
            Console.Clear();

            Console.WriteLine("Enter the Mark of this question");
            int mark = Validations.ValidateNumbers();
            Console.Clear();

            Answers[] answers = Answers.CreateMCQAnswers();

            Console.WriteLine("Enter the Number of Right Answer for this question from 1 , 2 , 3 , 4 ");
            int rightanswer = Validations.ValidateRightAnswerNumber(false);
            Console.Clear();

            return new MCQQuestion()
            {
                Header = $"MCQ Question {index + 1}",
                Body = body,
                Mark = mark,
                Answer = answers,
                RightAnswer = rightanswer
            };
        }
        public static MCQQuestion[] CreateQuestionsArray(int size)
        {
            MCQQuestion[] mCQQuestions = new MCQQuestion[size];
            if (size>0)
            {
                for (int i = 0; i < mCQQuestions.Length; i++)
                {
                    mCQQuestions[i] =CreateQuestion(i);
                }
            }
            return mCQQuestions;
        }
    }
}
