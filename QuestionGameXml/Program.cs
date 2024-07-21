using Microsoft.VisualBasic;
using QuestionGameXml.Services;
using System.Data;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace QuestionGameXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        XMLService xmlService = new XMLService("Data","QuestionsAndAnswers");
        static void Start()
        {
            Console.WriteLine("1. Create questions\r\n2. Answer Questions");
            string? res = Console.ReadLine();
            switch (res)
            {
                case "1":
                    CreateEvent();
                    break;
                case "2":
                    AnswerEvent();
                    break;
                case null:
                    Start();
                    break;
                default:
                    // code block
                    break;
            }

        }
        static void CreateEvent()
        {
            object NewQuestions = CreateNewQuestions();
            SaveInformationToXml(NewQuestions);
            Start();
        }
        static string CreateNewQuestions()
        {
            Console.WriteLine("-Type your question");
            string? question = Console.ReadLine();
            Console.WriteLine(" -Type the answer");
            string? answer = Console.ReadLine();

            return question;

        }
        static void SaveInformationToXml(Object NewQuestions)
        {

        }
        static void AnswerEvent()
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
