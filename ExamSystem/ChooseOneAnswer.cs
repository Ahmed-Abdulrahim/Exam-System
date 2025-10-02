using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class ChooseOneAnswer : Question
    {
        public ChooseOneAnswer(string _header , string _body , int _mark) : base(_header , _body , _mark) 
        {
          
        }
        public override bool CheckValue(string input)
        {
            int result;
            int.TryParse(input, out result);
            if (result >= 1 || result <= AnsList.Count) 
            {
                return AnsList[result - 1].IsCorrect;
            }
            return false;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"[Choose One Answer] \n  {Body}        ({Mark} Mark)");
            for (int i = 0; i < AnsList.Count; i++) 
            {
                Console.WriteLine($"{i+1}) {AnsList[i].Body}");
            }

        }
    }
}
