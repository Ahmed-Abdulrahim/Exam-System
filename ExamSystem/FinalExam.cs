using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class FinalExam : Exam
    {
        public FinalExam(Subject _subject, QuestionList _questionList, TimeSpan _DurationForExam) : base(_subject, _questionList, _DurationForExam)
        {
        }
        public override void ShowExam()
        {
            Start();
            Console.WriteLine($"Final Exam");

            foreach (var q in QuestionListForExam)
            {
                q.ShowQuestion();
                Console.WriteLine("Your answer: ");
                Console.ReadLine(); 
                Console.WriteLine();
            }

            Finished();
            Console.WriteLine("Exam submitted.");
        }
    }
}
