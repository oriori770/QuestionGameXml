using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionGameXml.Event
{
    public class Creation
    {
        public static void CreateEvent()
        {
            object NewQuestions = CreateNewQuestions();
            SaveInformationToXml(NewQuestions);
            Program.Start();           
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
    }
}
