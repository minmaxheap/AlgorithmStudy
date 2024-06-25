using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// Level4. 1차원 배열
    /// </summary>
    internal class Level4Helper
    {
        internal void Run()
        {
            try
            {
                Level4Method10();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 개수세기
        internal void Level4Method01()
        {
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                string[] arr = Console.ReadLine().Split(' ');
                int num = Convert.ToInt32(Console.ReadLine());

                int cnt = 0;
                for (int i = 0; i < count; i++)
                {
                    int x = Convert.ToInt32(arr[i]);
                    if (num == x)
                        cnt++;
                }
                Console.WriteLine(cnt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region A+B
        internal void Level4Method02()
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
        internal void Level4Method03()
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
        internal void Level4Method04()
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
        internal void Level4Method05()
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
        internal void Level4Method06()
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
        internal void Level4Method07()
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
        internal void Level4Method08()
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
        internal void Level4Method09()
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
        #region 별찍기 -2
        internal void Level4Method10()
        {
            try
            {
                int count = Convert.ToInt32(Console.ReadLine());
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 1; i <= count; i++)
                {
                    //i : 1 2 3 4 5
                    //x : 5 4 3 2 1
                    //count - i : 4 3 2 1 0
                    int a = count - i;
                    for (int x = 1; x <= a; x++)
                    {
                        sb.Append(' ');
                    }
                    for (int y = 1; y <= i; y++)
                    {
                        sb.Append('*');
                        if (y == i && y != count) sb.Append("\n");
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
        #region A + B - 5
        internal void Level4Method11()
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                int a = 0;
                int b = 0;
                while (true)
                {
                    string[] arr = Console.ReadLine().Split(' ');
                    a = Convert.ToInt32(arr[0]);
                    b = Convert.ToInt32(arr[1]);
                    if (a == 0 && b == 0)
                        break;
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
        #region A + B - 4
        internal void Level4Method12()
        {
            try
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                int a = 0;
                int b = 0;
                while (true)
                {
                    var str = Console.ReadLine();

                    if (str == null)
                        break;
                    string[] arr = str.Split(' ');
                    a = Convert.ToInt32(arr[0]);
                    b = Convert.ToInt32(arr[1]);
                    sb.Append($"{a + b} ");
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
