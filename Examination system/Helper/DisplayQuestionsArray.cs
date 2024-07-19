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
        public static void DisplayTrueFalseArray(TrueFalseQuestion[]trueFalseQuestions)
        {
            for (int i=0;i<trueFalseQuestions.Length;i++)
            {
                Console.WriteLine($"{trueFalseQuestions[i].ToString()}");
            }
        }

        public static void DisplayMCQArray(MCQQuestion[]mCQQuestions)
        {
            for (int i=0;i<mCQQuestions.Length;i++)
            {
                Console.WriteLine($"{mCQQuestions[i].ToString()}");
            }
        }
    }
}
