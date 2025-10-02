using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class ChooseMultipleAnswer :Question
    {
        public ChooseMultipleAnswer(string _header, string _body, int _mark) : base(_header, _body, _mark)
        {

        }

        public override bool CheckValue(string input)
        {
            IEnumerable<int> userInputs;
            userInputs = input.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.TryParse(x.Trim(), out int n) ? n : -1)
                .Where(n => n > 0);
            HashSet<int> results = new HashSet<int>(userInputs);
            for (int i = 0; i < AnsList.Count; i++) 
            {
                bool isCorrect = AnsList[i].IsCorrect;
                bool CorrectFromUser = results.Contains(i + 1);
                if(isCorrect !=CorrectFromUser) return false;
            }
            return true;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"[Choose Multiple Answer] \n  {Body}        ({Mark} Mark)");
            for (int i = 0; i < AnsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {AnsList[i].Body}");
            }
            Console.WriteLine("Plz Choose Multiple Answer Seprated By Comma");
        }
    }
}
