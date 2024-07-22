using Examination_system.Exame;
using Examination_system.Helper;
using Examination_system.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Subjects
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ExameType { get; set; }
        public BaseExame? Exame { get; set; }
        public Subject() 
        { 
            
        }
        public Subject(int Id,string Name,string ExameType)
        {
            this.Id = Id;
            this.Name = Name;
            this.ExameType = ExameType;
        }
        public static Subject AddSubject()
        {
            //Enter the ID of the subject
            Console.WriteLine("Enter the Id of subject : ");
            int subjectId = Validations.ValidateNumbers();
            Console.Clear();

            //Enter the Name of the subject
            Console.WriteLine("Enter the Name of subject : ");
            string subjectName = Validations.ValidateStrings();
            Console.Clear();

            //Enter the type of exame to be created
            Console.WriteLine("What the type of Exame You want to create : ( Final - Practical )");
            string examType = Validations.ValidateMatchStrings("final", "practical");
            Console.Clear();
            return new Subject(subjectId, subjectName, examType);
        }
        public  BaseExame CreateExame()
        {
            //Enter the Time of Exame
            Console.WriteLine("Enter the Time Of the Exame");
            int timeOfExame = Validations.ValidateNumbers();
            Console.Clear();

            //Enter the Number of Question
            Console.WriteLine("Enter the number of questions in this Exame");
            int numOfQuestions = Validations.ValidateNumbers();
            Console.Clear();
            BaseQuestion[] questions=BaseQuestion.CreateQuestionsArray(numOfQuestions , ExameType??"");

            if (ExameType?.CompareTo("practical") < 0)
            {
                FinalExame finalExame=new FinalExame(timeOfExame,numOfQuestions,questions);
                return finalExame;
            }
            else
            {
                PracticalExame practicalExame = new PracticalExame(timeOfExame,numOfQuestions,questions);
                return practicalExame;
            }
        }
        public override string ToString()
        {
            return $"Id: {Id} , Name: {Name} , Exame Type: {ExameType}";
        }
    }
}
