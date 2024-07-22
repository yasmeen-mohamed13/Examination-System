using Examination_system.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Answer
{
    public class Answers
    {
        public int Id { get; set; }
        public string? AnswerText { get; set; }

        public Answers()
        {

        }
        public Answers(int Id, string AnswerText)
        {
            this.Id = Id;
            this.AnswerText = AnswerText;
        }
        public override string ToString()
        {
            return $"{Id}- {AnswerText}";
        }
        public static void DisplayAnswersArray(Answers[] answers)
        {
            foreach (var item in answers)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static Answers[] CreateTrueFalseAnswer()
        {
            Answers[] answers = { new Answers(1, "True"), new Answers(2, "False") };
            return answers;
        }
        public static Answers[] CreateMCQAnswers()
        {
            Answers[]answers=new Answers[4];
            Console.WriteLine("Enter the 4 Answers for this question ");

            Console.ForegroundColor = ConsoleColor.Red;

            for (int j = 0; j < answers.Length; j++)
            {
                Console.WriteLine($"Answer {j + 1}");
                answers[j] = new Answers(j+1, Validations.ValidateStrings());
            }
            Console.ResetColor();

            return answers;
        }

    }
}
