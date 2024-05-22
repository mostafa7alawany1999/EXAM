using System.Diagnostics;

namespace EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject Subject = new Subject(10, "C#");
            Subject.Create_Exam();
            char Answer;
            do
            {
                Console.Write("Do You Want to Start The Exam(Y/N) : ");
            } while (!char.TryParse(Console.ReadLine(), out Answer));

            if (Answer == 'Y' || Answer == 'y')
            {
                Stopwatch sw = Stopwatch.StartNew();
                Subject.Exam.Show_Exam();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}\tTime Of Exam {Subject.Exam.Time_of_exam}");
            }
        }
    }
}
  