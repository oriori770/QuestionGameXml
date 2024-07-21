using QuestionGameXml.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuestionGameXml.Event
{
    public class Game
    {
        public XMLService xMLService;
        public void AnswerEvent(XMLService XMLService)
        {
            xMLService = XMLService; 
            XmlDocument ListOfQuestions = GetListOfQuestions();
            PrintListOfQuestions(ListOfQuestions);
        }
        static void PrintListOfQuestions(XmlDocument Questions)
        {
            Console.WriteLine("Type a number to select a question");
            foreach (XmlNode Question in Questions.DocumentElement)
            {
                Console.WriteLine("enter XmlDocument");
                Console.WriteLine(Question.SelectSingleNode("Question").InnerText);
            }
            //Console.WriteLine("1. what is foo?\r\n2. who is bar?");
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
        public XmlDocument GetListOfQuestions()
        {
            XmlDocument Questions = xMLService.ReadXML();
            return Questions;
        }

    }
}
