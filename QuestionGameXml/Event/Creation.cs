using QuestionGameXml.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionGameXml.Event
{
    public class Creation
    {
        public XMLService? _xmlService;
        public void CreateEvent(XMLService xmlService)
        {
            _xmlService = xmlService;
            string[] NewQuestions = CreateNewQuestions();
            SaveInformationToXml(NewQuestions);
            Program.Start(xmlService);           
        }



        public string[] CreateNewQuestions()
        {
            Console.WriteLine("-Type your question");
            string? question = Console.ReadLine();
            Console.WriteLine(" -Type the answer");
            string? answer = Console.ReadLine();
            string[] qa = { question, answer };

            return qa;

        }

        public void SaveInformationToXml(string[] NewQuestions)
        {
            _xmlService.AddQuestionAndAnswer(NewQuestions[0], NewQuestions[1]);
        }
    }
}
