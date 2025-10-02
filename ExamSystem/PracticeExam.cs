using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class PracticeExam : Exam
    {
        public PracticeExam(Subject _subject, QuestionList _questionList, TimeSpan _DurationForExam) : base(_subject, _questionList, _DurationForExam)
        {
        }

        public override void ShowExam()
        {
            Start();
            Console.WriteLine("Practice Exam");
            int score = 0;
            foreach(var q in QuestionListForExam) 
            {
                q.ShowQuestion();
                Console.Write("Your answer: ");
                string input = Console.ReadLine();
                var res = ParseInput(q, input);
                bool checkResult = q.CheckValue(res as string);
                if(checkResult)
                    score+=(int)q.Mark;
                Console.WriteLine(checkResult ? " Correct!" : " Wrong!");
                Console.WriteLine(" Correct Answers:");
                foreach (var ans in q.AnsList)
                {
                    if (ans.IsCorrect) Console.WriteLine("-" + ans.Body);
                }
                Console.WriteLine();
            }

            Finished();
            Console.WriteLine($"Your final score: {score}/{QuestionListForExam.Sum(q => (int)q.Mark)}");
        }
        
        public object ParseInput(Question q ,string input) 
        {
            if (q is TrueOrFalseQuestion || q is ChooseOneAnswer)
            {
                if (int.TryParse(input, out int num)) return num;
            }
            else if (q is ChooseMultipleAnswer) 
            {
                return input;
            }
            return null;
        }
    }
}
