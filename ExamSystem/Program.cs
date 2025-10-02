namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region True Or False
            /*TrueOrFalseQuestion q1 = new  TrueOrFalseQuestion("Cs", "Html is ", 2);
               q1.AnsList[0].IsCorrect = true;
               q1.AnsList[1].IsCorrect = false;
               q1.ShowQuestion();
               string input = Console.ReadLine();
               Console.WriteLine($"{q1.CheckValue(input)}");*/
            #endregion
            #region Choose One Answer
            /*ChooseOneAnswer q3 = new ChooseOneAnswer("Cs", "Html", 5);
               q3.AnsList.Add(new Answer("cs", true));
               q3.AnsList.Add(new Answer("csc"));
               q3.AnsList.Add(new Answer("sdsd"));
               q1.ShowQuestion();
               string input;
               input = Console.ReadLine();
               Console.WriteLine($"{q1.CheckValue(input)}");*/
            #endregion
            #region ChooseMultipleAnswer
            /*ChooseMultipleAnswer q2 = new ChooseMultipleAnswer("cs" , "What is " , 5);
              q2.AnsList.Add(new Answer("cs", true));
              q2.AnsList.Add(new Answer("dsad", true));
              q2.AnsList.Add(new Answer("dasdas", true));
              q2.AnsList.Add(new Answer("cs"));
              q1.ShowQuestion();
              string input  =Console.ReadLine();
              Console.WriteLine($"{q1.CheckValue(input)}");*/
            #endregion
            #region QuestionList
            /*string logPath = Path.Combine(Environment.CurrentDirectory, "QuestionsLog.txt");
               var qList = new QuestionList(logPath);
               qList.Add(q1);
               qList.Add(q2);
               qList.Add(q3);*/
            #endregion
            var subject = new Subject(0100, "General");
            string logPath = Path.Combine(Environment.CurrentDirectory, "QuestionList.txt");
            var qList = new QuestionList(logPath);
            var q1 = new TrueOrFalseQuestion("The sky is blue.", "Sky Color", 2);
            q1.AnsList[0].IsCorrect = true;   
            q1.AnsList[1].IsCorrect = false;  

            var q2 = new ChooseOneAnswer("Which number is even?", "Numbers", 3);
            q2.AnsList.Add(new Answer("3", false));
            q2.AnsList.Add(new Answer("4", true));
            q2.AnsList.Add(new Answer("5", false));

            var q3 = new ChooseMultipleAnswer("Which are fruits?", "Fruits", 5);
            q3.AnsList.Add(new Answer("Apple", true));
            q3.AnsList.Add(new Answer("Carrot", false));
            q3.AnsList.Add(new Answer("Banana", true));
            q3.AnsList.Add(new Answer("Potato", false));
            qList.Add(q1);
            qList.Add(q2);
            qList.Add(q3);

            Console.WriteLine(" Questions added In File.\n");
            var practiceExam = new PracticeExam(subject, qList, TimeSpan.FromMinutes(20));

           
            var finalExamList = new QuestionList(Path.Combine(Environment.CurrentDirectory, "FinalExamLog.txt"));
            foreach (var q in qList)
            {
                finalExamList.Add((Question)q.Clone()); 
            }
            var finalExam = new FinalExam(subject, finalExamList, TimeSpan.FromMinutes(60));
            var s1 = new Student("Ahmed");
            var s2 = new Student("Khaled");

            practiceExam.ExamStarted += s1.OnExamStarted;
            practiceExam.ExamStarted += s2.OnExamStarted;

            finalExam.ExamStarted += s1.OnExamStarted;
            string choice = "";

            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Choose exam type:");
                Console.WriteLine("1) Practice Exam");
                Console.WriteLine("2) Final Exam");
                Console.Write("Your choice: ");
                choice = Console.ReadLine();

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Invalid choice, please try again.\n");
                }
            }

            Console.WriteLine("\n=========================================\n");

            if (choice == "1")
            {
                practiceExam.ShowExam();
            }
            else if (choice == "2")
            {
                finalExam.ShowExam();
            }
        }
    }
}
