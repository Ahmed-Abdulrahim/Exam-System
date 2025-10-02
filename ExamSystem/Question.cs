using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExamSystem
{
    internal abstract class Question :ICloneable , IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public AnswerList AnsList { get; set; }
        public Question(string _header, string _body, int _mark) 
        {
            Header = _header;
            Body = _body;
            Mark = _mark;
            AnsList = new AnswerList();
        }
        public abstract void ShowQuestion();
        public abstract void CheckedValue(string input);

        public override string ToString()
        {
            return $"{GetType().Name} {Header} {Body} {Mark} mark";
           
        }
        public override bool Equals(object? obj)
        {
            if (obj is Question q) 
            {
                return Header ==q.Header && Body ==q.Body && Mark ==q.Mark;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Header, Body, Mark);
        }
        public virtual object Clone()
        {
            Question q = (Question)this.MemberwiseClone();
            q.AnsList = new AnswerList();
            foreach (Answer a in q.AnsList) 
            {
                q.AnsList.Add(new Answer(a.Body, a.IsCorrect));
            }
            return q;
        }

        public int CompareTo(Question? other)
        {
            if (other == null) return 1;
            return Mark.CompareTo(other.Mark);
        }
    }
}
