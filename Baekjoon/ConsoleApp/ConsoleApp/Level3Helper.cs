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
                Level3Method05();
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
                    Console.WriteLine($"{num} * {i} = {num * i}");

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
                for (int i = 1; i <= num; i++)
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
                if (string.IsNullOrEmpty(str) == false)
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
        #region 영수증
        internal void Level3Method04()
        {
            try
            {

                long total = Convert.ToInt64(Console.ReadLine());
                int count = Convert.ToInt32(Console.ReadLine());
                long sum = 0;

                for (int i = 1; i <= count; i++)
                {
                    string[] arr = Console.ReadLine().Split(' ');
                    long price = Convert.ToInt64(arr[0]);
                    int count2 = Convert.ToInt32(arr[1]);

                    sum += price * count2;
                }
                Console.WriteLine(total == sum ? "Yes" : "No");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 코딩은 체육과목 입니다
        internal void Level3Method05()
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string byte4 = "long int";
                int share = (num / 4) - 1;
                string str = "";
                for (int i = 1; i <= share; i++)
                {
                    str += "long ";
                }
                Console.WriteLine($"{str}{byte4}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 빠른 A+B
        internal void Level3Method06()
        {
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    string[] arr = Console.ReadLine().Split(' ');
                    int a = Convert.ToInt32(arr[0]);
                    int b = Convert.ToInt32(arr[1]);
                    sb.Append($"{a + b}\n");

                }
                Console.WriteLine(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region A+B -7
        internal void Level3Method07()
        {
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    string[] arr = Console.ReadLine().Split(' ');
                    int a = Convert.ToInt32(arr[0]);
                    int b = Convert.ToInt32(arr[1]);
                    sb.Append($"Case #{i + 1}: {a + b}\n");

                }
                Console.WriteLine(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region A+B -8
        internal void Level3Method08()
        {
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 1; i <= count; i++)
                {
                    string[] arr = Console.ReadLine().Split(' ');
                    int a = Convert.ToInt32(arr[0]);
                    int b = Convert.ToInt32(arr[1]);
                    sb.Append($"Case #{i}: {a} + {b} = {a + b}\n");

                }
                Console.WriteLine(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 별찍기 -1
        internal void Level3Method09()
        {
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 1; i <= count; i++)
                {
                    for (int x = 1; x <= i; x++)
                    {
                        sb.Append("*");
                        if (x == i) sb.Append("\n");
                    }
                }
                Console.WriteLine(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
