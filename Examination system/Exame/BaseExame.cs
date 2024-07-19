using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system.Exame
{
    abstract class BaseExame
    {
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        protected BaseExame()
        {
            
        }
        protected BaseExame(int Time,int NumOfQuestions)
        {
            this.Time = Time;
            this.NumOfQuestions = NumOfQuestions;
        }
        public abstract void Display();

        public void ShowTimeAndNumOfQuestions(int Time, int NumOfQuestions)
        {
            Console.WriteLine($"Time: {Time}, Number of Questions: {NumOfQuestions}");
        }
    }
}
