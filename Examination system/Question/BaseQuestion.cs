using Examination_system.Answer;
using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Question
{
    public abstract class BaseQuestion
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
        public void displayQuestion(int index)
        {
            
            Console.WriteLine($"Question {index+1} : {Header} \n===========================\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Body}\n");
            Answers.DisplayAnswersArray(Answer);
            Console.WriteLine();
            
            Console.ResetColor();
        }
        public static BaseQuestion CreateQuestion(int index,string typeofexame)
        {
            string Header;
            if (typeofexame.ToLower().CompareTo("practical") < 0)
            {
                Console.WriteLine($"Enter Header of Question {index + 1} if it will be ( MCQ - True or False )");
                Header = Validations.ValidateMatchStrings("mcq", "true or false");
            }
            else
            {
                Header =$"mcq";
            }

            Console.WriteLine("Enter the question");
            
            Console.ForegroundColor = ConsoleColor.Red;
            string body = Validations.ValidateStrings();
            Console.ResetColor();

            Console.Clear();

            Console.WriteLine("Enter the Mark of this question");

            Console.ForegroundColor = ConsoleColor.Red;
            int mark = Validations.ValidateNumbers();
            Console.ResetColor();

            Console.Clear();

            Answers[] answers ;
            int rightanswer;
            if (Header.CompareTo("mcq")==0)
            {
                answers = Answers.CreateMCQAnswers();
                Console.WriteLine("Enter the Number of Right Answer for this question from ( 1 , 2 , 3 ,4 )");

                Console.ForegroundColor = ConsoleColor.Red;
                rightanswer = Validations.ValidateRightAnswerNumber(false);
                Console.ResetColor();

                Console.Clear();
                return new MCQQuestion()
                {
                    Header = Header,
                    Body = body,
                    Mark = mark,
                    Answer = answers,
                    RightAnswer = rightanswer
                };

            }
            else
            {
                answers = Answers.CreateTrueFalseAnswer();
                Console.WriteLine("Enter the Number of Right Answer for this question ( 1- True , 2- False )");

                Console.ForegroundColor = ConsoleColor.Red;
                rightanswer = Validations.ValidateRightAnswerNumber(true);
                Console.ResetColor();

                Console.Clear();
                return new TrueFalseQuestion()
                {
                    Header = Header,
                    Body = body,
                    Mark = mark,
                    Answer = answers,
                    RightAnswer = rightanswer
                };
            }
        }
        public static BaseQuestion[] CreateQuestionsArray(int size , string typeofexame)
        {
            BaseQuestion [] questions = new BaseQuestion[size];
            
            if (size > 0)
            {
                for (int i = 0; i < questions.Length; i++)
                {
                    questions[i] = CreateQuestion(i, typeofexame);
                }
            }
            return questions;
        }

    }
}
