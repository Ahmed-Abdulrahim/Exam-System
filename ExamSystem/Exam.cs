using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public enum ExamMode { Queued , Started , Finished}
    internal abstract class Exam
    {
        public Subject? SubjectForExam { get; set; }
        public QuestionList? QuestionListForExam { get; set; }
        public TimeSpan DurationForExam { get; set; }
        public ExamMode ExamMode { get; set; } = ExamMode.Queued;
        public Dictionary<Question, AnswerList> QuestionAnswers { get; set; }
        = new Dictionary<Question, AnswerList>();
        public Exam(Subject _subject , QuestionList _questionList ,TimeSpan _DurationForExam)
        {
            SubjectForExam = _subject ;
            QuestionListForExam = _questionList ;
            DurationForExam = _DurationForExam ;
        }
        public abstract void ShowExam();
        public virtual void Start()
        {
            ExamMode = ExamMode.Started;
            Console.WriteLine($"Exam For {SubjectForExam?.Name} has started , Time limit: {DurationForExam.TotalMinutes} minutes");
        }
        public virtual void Finished() 
        {
            ExamMode = ExamMode.Finished;
            Console.WriteLine("Exam Finished ");
        }
        public override string ToString()
        {
            return $"Exam for {SubjectForExam?.Name} ({SubjectForExam?.ID}) | Questions: {QuestionListForExam?.Count} | Time: {DurationForExam.TotalMinutes} mins | Mode: {ExamMode}";
        }


    }
}
