using Examination_system.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examination_system.Helper
{
    public static class Validations
    {
        public static int ValidateNumbers()
        {
            int validNumber;
            while (!int.TryParse(Console.ReadLine(), out validNumber))
            {
                Console.WriteLine("Enter Only Numbers");
            }

            return validNumber;
        }
        public static int ValidateRightAnswerNumber(bool flag1)
        {
            int result=0;
            bool flag=true;
            //flag1 == true  ==> true false => size of answers 1, 2
            while (flag)
            {
                result=ValidateNumbers();
                if (flag1)
                {
                    if (result==1 || result==2)
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Number Should Be 1 Or 2");
                    }
                }
                else
                {
                    if (result == 1 || result == 2 || result == 3 || result == 4)
                    {
                        flag = false;
                    }
                    else 
                    {
                        Console.WriteLine("Number Should Be 1 or 2 or 3 or 4");
                    }
                }
            }
            return result;
        }
        public static string ValidateStrings()
        {
            string Input;
            Regex regex = new Regex("^[A-Za-z]+[A-Za-z !@#$%^&*()_+\\-=\\[\\]{};':\"\\\\|,.<>\\/?]*$");
            while (!regex.IsMatch(Input = Console.ReadLine() ?? "") || String.IsNullOrEmpty(Input))
            {
                Console.WriteLine("Enter a valid Name without special charactes or numbers or white Space");
            }

            return Input;
        }
        public static string ValidateMatchStrings(string firtMatch,string secondMatch)
        {
            string input = Console.ReadLine() ?? "".ToLower(); ;
            while (input.Length< firtMatch.Length && input.Length< secondMatch.Length)
            {
                Console.WriteLine($"Please Enter valid choose : \n{firtMatch} \n{secondMatch}");
                input = Console.ReadLine() ?? "".ToLower();
            }
            Console.Clear();
            return input;
        }
        public static int ValidateSizeOfQuestionArray(int totalNumOfQuestions)
        {
            int Input;
            while (!int.TryParse(Console.ReadLine(), out Input) || Input > totalNumOfQuestions)
            {
                Console.WriteLine("Enter Only Numbers and less than or equal the total number of questions you already choose ");
            }
            Console.Clear();
            return Input;
        }
    }
}
