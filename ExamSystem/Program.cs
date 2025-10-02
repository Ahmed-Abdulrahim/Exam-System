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


        }
    }
}
