using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class Guesser
    {
        private int[] answers;  //答案庫
        private Random random;
        private int guessedNumber;  //所猜的數字

        public int A { get; set; }  //比較結果 A 的值
        public int B { get; set; }  //比較結果 B 的值
        public int Remains { get; set; }    //剩餘可能答案數

        public Guesser()
        {
            this.answers = new int[10 * 9 * 8 * 7];
            this.random = new Random();
        }

        // 初始化及把所有答案放到答案庫
        public void InitAnswers()
        {
            int n1, n2, n3, n4;

            this.Remains = 0;
            this.guessedNumber = 0;
            this.A = this.B = 0;

            // 從 0123 到 9876 中取出各位數字不同的數字到答案庫
            for (int i = 123; i <= 9876; i++)
            {
                n1 = i / 1000;
                n2 = (i / 100) % 10;
                n3 = (i / 10) % 10;
                n4 = i % 10;

                if (n1 != n2 && n1 != n3 && n1 != n4 && n2 != n3 && n2 != n4 && n3 != n4)
                    this.answers[this.Remains++] = i;
            }
        }

        // 從剩下的答案中猜一個數字
        public int GuessNumber()
        {
            if (this.guessedNumber != 0)
                this.delAnswers();

            this.guessedNumber = this.Remains == 0 ? 0 : this.answers[random.Next(0, this.Remains)];

            return this.guessedNumber;
        }

        // 比較兩個數字是 ? A ? B, 結果存在 this.A, this.B
        public void CompareNumber(int num1, int num2)
        {
            int[] n1 = new int[4] { num1 / 1000, (num1 / 100) % 10, (num1 / 10) % 10, num1 % 10 };
            int[] n2 = new int[4] { num2 / 1000, (num2 / 100) % 10, (num2 / 10) % 10, num2 % 10 };

            this.A = this.B = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (n1[i] == n2[j])  // num1 與 num2 某個數字相等
                    {
                        if (i == j) // 數字相等且位置相同 => +1 個 A
                            this.A++;
                        else        // 數字相等且位置不同 => +1 個 B
                            this.B++;
                    }
                }
            }
        }

        // 從答案庫 answers 刪除與 guessedNumber 比較結果不是 a A b B 的答案
        public void delAnswers()
        {
            int a = this.A, b = this.B, i = 0;

            while (i < this.Remains)
            {
                // 比較 answerNum 與 guessedNum 是 ? A ? B
                CompareNumber(this.answers[i], guessedNumber);

                // 若 this.A != a 或 this.B != b 則從答案庫刪除此答案(以答案庫最後一個答案取代此答案)
                if (a != this.A || b != this.B)
                {
                    this.answers[i] = answers[this.Remains - 1];
                    this.Remains--;
                    continue;
                }

                i++;
            }
        }
    }
}