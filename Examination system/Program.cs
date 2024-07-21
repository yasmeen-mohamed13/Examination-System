using Examination_system.Answer;
using Examination_system.Exame;
using Examination_system.Helper;
using Examination_system.Question;
using Examination_system.Subjects;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ========================= start asking for create exame =============================
            
            Console.WriteLine("Do you want to Create Exame or Solve Exame ?");
            string userInput = Validations.ValidateMatchStrings("create", "solve");
            Console.Clear();

            if (userInput.CompareTo("solve") < 0)
            {
                // ================================ Create Subject =================================

                Subject subject = Subject.AddSubject();

                subject.Exame = subject.CreateExame();

                //================================= Ask to Start Exame ==============================
                
                Console.WriteLine("Do You Want To Start Exame? ( yes | no )");
                string startExame = Console.ReadLine() ?? "";

                if (startExame.CompareTo("yes") == 0)
                {
                    Stopwatch sw = Stopwatch.StartNew();
                    Console.Clear();
                    subject.Exame.Display();
                    Console.WriteLine($"The Elapsed Time is : {sw.Elapsed}");
                }
            }
                // =============================== if he choose solve exame at first =============================
            else
            {
                 Console.WriteLine("There is No Exames Created yet");
            }
        }
    }
}
