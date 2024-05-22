using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Subject
    {
        public Exam Exam { get; set; }
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public Subject()
        {
            
        }
        public Subject(int Subject_Id, string Subject_Name)
        {
            this.Subject_Id = Subject_Id;
            this.Subject_Name = Subject_Name;

        }
        int ExamType;
        int Time;
        int Num_Of_Ques;
        public void Create_Exam()
        {
            //int ExamType;
            //int Time;
            //int Num_Of_Ques;
            do
            {
                Console.Write("Please Enter Type Of Exam \t1.Practical  ||\t2.Final :  ");

            }
            while (!int.TryParse(Console.ReadLine(), out ExamType ) || ExamType > 2|| ExamType < 0);

            do
            {
                Console.Write("Please Enter Time Of Exam (Minutes):  ");
            }
            while (!int.TryParse(Console.ReadLine(), out Time) || Time < 0);
            
            do
            {
                Console.Write("Please Enter Number Of Questions Of Exam:   ");

            }
            while (!int.TryParse(Console.ReadLine(), out Num_Of_Ques) || Num_Of_Ques < 0);
            Console.Clear();
            switch (ExamType)
            {
                case 1: 
                    Exam=new Practical_Exam(Time,Num_Of_Ques); 
                    Exam.Create_Exam();
                    break;
                    case 2:
                    Exam = new Final_Exam(Time, Num_Of_Ques);
                    Exam.Create_Exam();
                    break;
            }


        }
        public void Display_Exam()
        {
            //Exam = new Final_Exam(Time,Num_Of_Ques);
            Exam.Show_Exam();
        }
    }
}
