using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// Level3. 반복문
    /// </summary>
    internal class Level3Helper
    {
        internal void Run()
        {
            try
            {
                Level3Method01();
                //Level3Method02();
                //Level3Method03();
                //Level3Method04();
                //Level3Method05();
                //Level3Method06();
                //Level3Method07();
                //Level3Method08);
                //Level3Method09();
                //Level3Method10();
                //Level3Method13();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 구구단
        internal void Level3Method01()
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine($"{num} * {i} = {num*i}");

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region A+B
        internal void Level3Method02()
        {
            try
            {
                int num;
                num = Convert.ToInt32(Console.ReadLine());
                for(int i = 1; i <= num; i++)
                {
                    string[] arr = Console.ReadLine().Split(' ');
                    int a = Convert.ToInt32(arr[0]);
                    int b = Convert.ToInt32(arr[1]);
                    Console.WriteLine(a + b);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 합
        internal void Level3Method03()
        {
            try
            {
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)==false)
                {

                    int number = Convert.ToInt32(str);
                    int sum = 0;
                    for (int i = 1; i <= number; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 사분면 고르기
        internal void Level3Method04()
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
        internal void Level3Method05()
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
