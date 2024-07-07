using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Level2. 조건문
    /// </summary>
    internal class Level2Helper
    {
        internal void Run()
        {
            try
            {
                Level2Method01();
                //Level2Method02();
                //Level2Method03();
                //Level2Method04();
                //Level2Method05();
                //Level2Method06();
                //Level2Method07();
                //Level2Method08);
                //Level2Method09();
                //Level2Method10();
                //Level2Method13();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 두 수 비교하기
        internal void Level2Method01()
        {
            try
            {
                string[] arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);

                int c = a - b;
                string str;

                if (c > 0) str = ">";
                else if (c < 0) str = "<";
                else str = "==";

                //if (a>b) str = ">";
                //else if (a<b) str = "<";
                //else str = "==";

                Console.WriteLine(str);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 시험 성적
        internal void Level2Method02()
        {
            try
            {
                string str;
                str = Console.ReadLine();
                int score = Convert.ToInt32(str);

                string grade;
                if (score >= 90) grade = "A";
                else if (score >= 80) grade = "B";
                else if (score >= 70) grade = "C";
                else if (score >= 60) grade = "D";
                else grade = "F";


                Console.WriteLine(grade);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 윤년
        internal void Level2Method03()
        {
            try
            {
                //윤년은 4의 배수 AND (100의 배수가 아닐 때 OR 400의 배수)
                //윤년이면 1, 아니면 0 출력
                string str;
                str = Console.ReadLine();
                int number = Convert.ToInt32(str);
                bool leapFlag = false;
                if (number % 4 == 0 && (number % 100 != 0 || number % 400 == 0))
                {
                    leapFlag = true;
                }
                Console.WriteLine(leapFlag ? 1 : 0);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 사분면 고르기
        internal void Level2Method04()
        {
            try
            {

                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                int quadrant;
                if (x > 0 && y > 0)
                {
                    quadrant = 1;
                }
                else if (x < 0 && y > 0)
                {
                    quadrant = 2;
                }
                else if (x < 0 && y < 0)
                {
                    quadrant = 3;
                }
                else quadrant = 4;
                Console.WriteLine(quadrant);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 주사위 세개
        internal void Level2Method05()
        {
            try
            {
                //같은 눈이 3개가 나오면 10,000원 + (같은 눈)×1,000원의 상금을 받게 된다.
                //같은 눈이 2개만 나오는 경우에는 1,000원 + (같은 눈)×100원의 상금을 받게 된다.
                //모두 다른 눈이 나오는 경우에는(그 중 가장 큰 눈)×100원의 상금을 받게 된다.
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                int dice1 = Convert.ToInt32(arr[0]);
                int dice2 = Convert.ToInt32(arr[1]);
                int dice3 = Convert.ToInt32(arr[2]);

                int price;

                if (dice1 == dice2 && dice2 == dice3)
                {
                    price = 10000 + dice1 * 1000;
                }
                else if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)
                {
                    bool bFlag1 = dice1 == dice2 ? true : false;
                    bool bFlag2 = dice2 == dice3 ? true : false;
                    if (bFlag1) price = 1000 + dice1 * 100;
                    else if (bFlag2) price = 1000 + dice2 * 100;
                    else price = 1000 + dice3 * 100;
                }
                else
                {
                    int[] value = new int[3];
                    value[0] = dice1;
                    value[1] = dice2;
                    value[2] = dice3;
                    int max = value.Max();
                    price = max * 100;
                }

                Console.WriteLine($"{price}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
