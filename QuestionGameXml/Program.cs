using Microsoft.VisualBasic;
using QuestionGameXml.Event;
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

        public static void Start()
        {
            Console.WriteLine("1. Create questions\r\n2. Answer Questions");
            string? res = Console.ReadLine();
            switch (res)
            {
                case "1":
                    Creation.CreateEvent();
                    break;
                case "2":
                    Game.AnswerEvent();
                    break;
                case null:
                    Start();
                    break;
                default:
                    // code block
                    break;
            }

        }

    }
}
