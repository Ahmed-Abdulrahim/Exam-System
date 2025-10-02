using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class TrueOrFalseQuestion : Question
    {
        public TrueOrFalseQuestion(string _header , string _body , int _mark ) : base(_header , _body , _mark) 
        {
            AnsList.Add(new Answer("True"));
            AnsList.Add(new Answer("False"));
        }
        public override bool CheckValue(string input)
        {
            int result;
            int.TryParse(input, out result);
            if (result == 1 || result == 2) 
            {
                return AnsList[result - 1].IsCorrect;
            }
            return false;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"[True/False] \n {Header} {Body}    ({Mark} Mark)");
            Console.WriteLine("1) True");
            Console.WriteLine("2) False");

        }
    }
}
