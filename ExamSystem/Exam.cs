using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    public enum ExamMode { Queued , Started , Finished}
    public delegate void ExamStartedHandler(object sender, ExamArgs e);
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public Subject SubjectForExam { get; set; }
        public QuestionList QuestionListForExam { get; set; }
        public TimeSpan DurationForExam { get; set; }
        public ExamMode ExamMode { get; set; } = ExamMode.Queued;
        public Dictionary<Question, AnswerList> QuestionAnswers { get; set; }
        = new Dictionary<Question, AnswerList>();
        public event ExamStartedHandler ExamStarted;
        public Exam(Subject _subject , QuestionList _questionList ,TimeSpan _DurationForExam)
        {
            SubjectForExam = _subject ;
            QuestionListForExam = _questionList ;
            DurationForExam = _DurationForExam ;
        }
        public abstract void ShowExam();
        public virtual void OnExamStarted(string msg)
        {
            ExamStarted?.Invoke(this, new ExamArgs(this, msg));
        }
        public virtual void Start()
        {
            ExamMode = ExamMode.Started;
            Console.WriteLine($"Exam For {SubjectForExam?.Name} has started , Time limit: {DurationForExam.TotalMinutes} minutes");
            OnExamStarted("");
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

        public object Clone()
        {
            Exam exam = (Exam)this.MemberwiseClone();
            exam.QuestionListForExam = new QuestionList($"{SubjectForExam.ID}.txt");
            foreach (var q in QuestionListForExam)
            {
                exam.QuestionListForExam.Add((Question)q.Clone());
            }
            return exam;
        }

        public int CompareTo(Exam? other)
        {
            if (other == null) return 1;
            int comp = QuestionListForExam.Count.CompareTo(other.QuestionListForExam.Count);
            if (comp == 0)
                comp = DurationForExam.CompareTo(other.DurationForExam);
            return comp;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Exam q)
            {
                return SubjectForExam.ID == q.SubjectForExam.ID && QuestionListForExam == q.QuestionListForExam && DurationForExam == q.DurationForExam;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(SubjectForExam.ID, QuestionListForExam, DurationForExam); 
        }
    }
}
