using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] targetNum = new int[4];
            int[] guessNum = new int[4];
            int i, j, a, b;

            for (i = 0; i < 4; i++)
            {
                do //產生0~9亂數, 並過濾重複的數字
                {
                    targetNum[i] = random.Next(0, 10);

                    for (j = 0; j < i; j++) //比較第 i 個數字與前 i-1 個數字是否有重複
                    {
                        if (targetNum[i] == targetNum[j])
                            break;
                    }
                } while (j < i); //繼續比較第 i 個數字與前 i-1 個數字是否有重複
            }

            //Console.WriteLine(string.Format("targetNum = {0}{1}{2}{3}", targetNum[0], targetNum[1], targetNum[2], targetNum[3]));
            a = b = 0;

            do
            {
                Console.WriteLine("猜答案:");
                string line = Console.ReadLine();

                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < i; j++) //比較第 i 個數字與前 i-1 個數字是否有重複
                    {
                        if (line[i] == line[j])
                            break;
                    }

                    if (line[i] < '0' || line[i] > '9' || j < i)
                    {
                        Console.WriteLine("輸入錯誤");
                        break;
                    }
                    else
                        guessNum[i] = int.Parse(line[i].ToString());
                }

                if (i < 4)  // 當輸入有錯誤時重新輸入
                    continue;

                // 比較兩個數字是 a A b B
                a = b = 0;

                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (guessNum[i] == targetNum[j])  // guessNum 與 targetNum 某個數字相等
                        {
                            if (i == j) // 數字相等且位置相同 => +1 個 A
                                a++;
                            else        // 數字相等且位置不同 => +1 個 B
                                b++;
                        }
                    }
                }

                Console.WriteLine(string.Format("{0} A {1} B", a, b));
            } while (a < 4);

            Console.WriteLine("猜對了!");
        }
    }
}