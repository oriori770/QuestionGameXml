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
            XMLService xmlService = new XMLService("Data","QuestionsAndAnswers.xml");
            xmlService.CreateXML();
            Start(xmlService);

        }


        public static void Start(XMLService xmlService)
        {
            Console.WriteLine("1. Create questions\r\n2. Answer Questions");
            string? res = Console.ReadLine();
            switch (res)
            {
                case "1":
                    var c = new Creation();
                    c.CreateEvent(xmlService);
                    break;
                case "2":
                    var g = new Game();
                    g.AnswerEvent(xmlService);
                    break;
                case null:
                    Start(xmlService);
                    break;
                default:
                    // code block
                    break;
            }

        }

    }
}
