using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionGameXml.Event
{
    public class Game
    {

        public static void AnswerEvent()
        {
            object ListOfQuestions = GetListOfQuestions();
        }
        static void PrintListOfQuestions(List<object> Questions)
        {
            Console.WriteLine("Type a number to select a question");
            foreach (object Question in Questions)
            {
            }
            Console.WriteLine("1. what is foo?\r\n2. who is bar?");
            string? QuestionNumber = Console.ReadLine();
            AnswerQuestions(QuestionNumber);
        }
        static void AnswerQuestions(string QuestionNumber)
        {
            string? Answer = Console.ReadLine();
            if (QuestionNumber == null || Answer == null)
            {
                Console.WriteLine("Enter information!!");
                AnswerCheck();
            }
            else if (AnswerCheck())
            {
                Console.WriteLine("correct answer");
            }
            else if (!AnswerCheck())
            {
                Console.WriteLine("wrong answer");
                Console.WriteLine("Try again");
            }

        }
        static bool AnswerCheck()
        {
            return true;
        }
        static List<object> GetListOfQuestions()
        {
            return new List<object>();
        }

    }
}
