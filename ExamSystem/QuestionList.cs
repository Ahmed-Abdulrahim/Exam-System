using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class QuestionList :List<Question>
    {
        string filePath;
        public QuestionList(string _filPath) 
        {
            filePath = _filPath ?? throw new ArgumentNullException(nameof(_filPath));
            string? dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
        public new void Add(Question q) 
        {
            base.Add(q);
            try 
            {
                using (var sw = new StreamWriter(filePath , true)) 
                {
                    sw.WriteLine($"[{DateTime.Now}] {q.GetType().Name} {q.Header}");
                    sw.WriteLine($"Body : {q.Body} Marks : {q.Mark}");
                    foreach (var a in q.AnsList)
                    {
                        sw.WriteLine($"Answer: {a.Body} | Correct: {a.IsCorrect}");
                    }
                    sw.WriteLine("=====================");
                }
            } 
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
