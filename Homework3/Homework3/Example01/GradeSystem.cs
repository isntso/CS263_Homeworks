using ScoreCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class GradeSystem
    {
        private int count;  //學生人數
        private int chinese;    //國文成績
        private int english;    //英文成績
        private int math;   //數學成績
        private Student[] student;  //學生陣列
        private string name;    //學生姓名

        private void InputGrade()
        {
            do
            {
                Console.Write("請輸入學生人數: ");
            } while (!int.TryParse(Console.ReadLine(), out count) || count < 0);

            student = new Student[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write(string.Format("請輸入第 {0} 個學生姓名: ", i + 1));
                name = Console.ReadLine();

                do
                {
                    Console.Write(string.Format("請輸入第 {0} 個學生國文成績:", i + 1));
                } while (!int.TryParse(Console.ReadLine(), out chinese));

                do
                {
                    Console.Write(string.Format("請輸入第 {0} 個學生英文成績:", i + 1));
                } while (!int.TryParse(Console.ReadLine(), out english));

                do
                {
                    Console.Write(string.Format("請輸入第 {0} 個學生數學成績:", i + 1));
                } while (!int.TryParse(Console.ReadLine(), out math));

                student[i] = new Student(name, chinese, english, math);
            }
        }

        private void OutputGrade()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(student[i]);
        }

        public void Run()
        {
            InputGrade();
            OutputGrade();
        }
    }
}