using Examination_system.Answer;
using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    public class BaseQuestion
    {
        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark { get; set; }
        public int RightAnswer { get; set; }
        public Answers[] Answer { get; set; }
        public BaseQuestion()
        {
          Answer = new Answers[0];
        }
        public BaseQuestion(string Header,string Body,int Mark, Answers[]Answers,int RightAnswer)
        {
            this.Header = Header;
            this.Body = Body;
            this.Mark = Mark;
            this.Answer=Answers;
            this.RightAnswer = RightAnswer;
        }
        public void displayQuestion()
        {
            Console.WriteLine($"{Header} Question :\n=======================\n{Body}\n");
            Answers.DisplayAnswersArray(Answer);
            Console.WriteLine();
        }
        public static BaseQuestion CreateQuestion(int index)
        {
            Console.WriteLine($"Enter Header of Question {index + 1} if it will be (MCQ - True or False)");
            string Header = Validations.ValidateMatchStrings("mcq", "true or false");
            Console.WriteLine("Enter the question");
            string body = Validations.ValidateStrings();
            Console.Clear();

            Console.WriteLine("Enter the Mark of this question");
            int mark = Validations.ValidateNumbers();
            Console.Clear();

            Answers[] answers ;
            int rightanswer;
            if (Header.CompareTo("mcq")==0)
            {
                answers = Answers.CreateMCQAnswers();
                Console.WriteLine("Enter the Number of Right Answer for this question from ( 1 , 2 , 3 ,4 )");
                rightanswer = Validations.ValidateRightAnswerNumber(false);

            }
            else
            {
                answers = Answers.CreateTrueFalseAnswer();
                Console.WriteLine("Enter the Number of Right Answer for this question (1- True , 2- False)");
                rightanswer = Validations.ValidateRightAnswerNumber(true);
            }
            Console.Clear();

            return new BaseQuestion()
            {
                Header = Header,
                Body = body,
                Mark = mark,
                Answer = answers,
                RightAnswer = rightanswer
            };
        }
        public static BaseQuestion[] CreateQuestionsArray(int size)
        {
            BaseQuestion [] questions = new BaseQuestion[size];
            if (size > 0)
            {
                for (int i = 0; i < questions.Length; i++)
                {
                    questions[i] = CreateQuestion(i);
                }
            }
            return questions;
        }

    }
}
