using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                Level4Method02();


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
        #region X보다 작은 수
        internal void Level4Method02()
        {

            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;

                string[] arr = str.Split(' ');
                int cnt = Convert.ToInt32(str[0]);
                int x = Convert.ToInt32(str[1]);

                string? str2 = Console.ReadLine();
                if (str2 == null) return;
                string[] arr2 = str2.Split(' ');

                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < cnt; i++)
                {
                    int temp = Convert.ToInt32(arr2[i]);
                    if (temp < x)
                    {
                        sb.Append($"{temp} ");
                    }
                }
                Console.WriteLine(sb.ToString().TrimEnd(' '));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 최소, 최대
        internal void Level4Method03()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;

                int cnt = Convert.ToInt32(str);

                string? str2 = Console.ReadLine();
                if (str2 == null) return;
                string[] arr2 = str2.Split(' ');

                int min = 0;
                int max = 0;
                int[] ints = new int[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    int temp = Convert.ToInt32(arr2[i]);
                    if (i == 0)
                    {
                        min = temp;
                        max = temp;

                    }
                    else
                    {
                        if (temp < min)
                        {
                            min = temp;
                        }
                        if (temp > max)
                        {
                            max = temp;
                        }

                    }

                }
                Console.WriteLine($"{min} {max}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 최댓값
        internal void Level4Method04()
        {
            try
            {
                int cnt = 9;
                int[] ints = new int[cnt];
                int max = 0;
                int index = 0;
                for (int i = 0; i < cnt; i++)
                {
                    string str = Console.ReadLine();
                    if(str == null) return;
                    int temp = Convert.ToInt32(str);
                    //ints[i] = temp;
                    if (i == 0) max = temp;
                    else if(temp>max)
                    {
                        max = temp;
                        index = i;
                    }
                }

                Console.WriteLine(max);
                Console.WriteLine(index);


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
