using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Subject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Subject(int _id, string _name) 
        {
            ID = _id;
            Name = _name;
        }
        public override string ToString()
        {
            return $"ID :{ID} , Name :{Name}";
        }
    }
}
