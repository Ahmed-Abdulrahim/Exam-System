using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Answer
    {
        public string Body { get; set; }
        public bool IsCorrect { get; set; }
        public Answer(string _body , bool _isCorrect = false) 
        {
            Body = _body;
            IsCorrect = _isCorrect;
        }
        public override string ToString() 
        
        {
            return $"{Body} {(IsCorrect ? "Correct" : "" )}";
        }
    }
    class AnswerList : List<Answer> 
    {
      
    }
}
