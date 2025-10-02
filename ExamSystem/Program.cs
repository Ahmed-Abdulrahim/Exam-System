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
            /*ChooseOneAnswer q1 = new ChooseOneAnswer("Cs", "Html", 5);
               q1.AnsList.Add(new Answer("cs", true));
               q1.AnsList.Add(new Answer("csc"));
               q1.AnsList.Add(new Answer("sdsd"));
               q1.ShowQuestion();
               string input;
               input = Console.ReadLine();
               Console.WriteLine($"{q1.CheckValue(input)}");*/
            #endregion
            #region ChooseMultipleAnswer
            /* ChooseMultipleAnswer q1 = new ChooseMultipleAnswer("cs" , "What is " , 5);
               q1.AnsList.Add(new Answer("cs", true));
               q1.AnsList.Add(new Answer("dsad", true));
               q1.AnsList.Add(new Answer("dasdas", true));
               q1.AnsList.Add(new Answer("cs"));
               q1.ShowQuestion();
               string input  =Console.ReadLine();
               Console.WriteLine($"{q1.CheckValue(input)}");*/ 
            #endregion


        }
    }
}
