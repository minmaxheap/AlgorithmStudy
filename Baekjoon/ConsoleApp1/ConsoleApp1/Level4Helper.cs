﻿using Microsoft.VisualBasic;
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
                Level4Method09();


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
                    if (str == null) return;
                    int temp = Convert.ToInt32(str);
                    //ints[i] = temp;
                    if (i == 0) max = temp;
                    else if (temp > max)
                    {
                        max = temp;
                        index = i;
                    }
                }

                Console.WriteLine(max);
                Console.WriteLine(index + 1);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 공 넣기
        internal void Level4Method05()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                string[] arr = str.Split(' ');
                int n = Convert.ToInt32(arr[0]);
                int m = Convert.ToInt32(arr[1]);

                int[] basket = new int[n];
                for (int i = 0; i < m; i++)
                {
                    string? str2 = Console.ReadLine();
                    if (str2 == null) return;
                    string[] arr2 = str2.Split(' ');
                    int first = Convert.ToInt32(arr2[0]) - 1;
                    int last = Convert.ToInt32(arr2[1]) - 1;
                    int num = Convert.ToInt32(arr2[2]);
                    for (int j = first; j <= last; j++)
                    {
                        basket[j] = num;
                    }

                }
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //for(int x = 0; x< n; x++)
                //{
                //    sb.Append($"{ints[x]}");
                //}
                //Console.WriteLine(sb.ToString().TrimEnd());

                Console.WriteLine(string.Join(" ", basket));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 공 바꾸기
        internal void Level4Method06()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                string[] arr = str.Split(' ');
                int n = Convert.ToInt32(arr[0]);
                int m = Convert.ToInt32(arr[1]);

                int[] basket = new int[n];
                for (int cnt = 0; cnt < n; cnt++)
                {
                    basket[cnt] = cnt + 1;
                }
                for (int x = 0; x < m; x++)
                {
                    string? str2 = Console.ReadLine();
                    if (str2 == null) return;
                    string[] arr2 = str2.Split(' ');
                    int i = Convert.ToInt32(arr2[0]) - 1;
                    int j = Convert.ToInt32(arr2[1]) - 1;
                    int a = basket[i];
                    int b = basket[j];
                    basket[i] = b;
                    basket[j] = a;

                }
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();
                //for(int x = 0; x< n; x++)
                //{
                //    sb.Append($"{ints[x]} ");
                //}
                //Console.WriteLine(sb.ToString().TrimEnd());

                Console.WriteLine(string.Join(" ", basket));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 과제 안 내신 분
        internal void Level4Method07()
        {
            try
            {
                int num = 28;
                int[] ints = new int[num];
                for (int i = 0; i < num; i++)
                {
                    string? str = Console.ReadLine();
                    if (str == null) continue;
                    int temp = Convert.ToInt32(str);
                    ints[i] = temp;
                }
                int cnt2 = 2;
                int[] answer = new int[cnt2];
                int cnt = 0;
                for (int i = 1; i <= 30; i++)
                {
                    if (!ints.Contains(i))
                    {
                        answer[cnt] = i;
                        cnt++;
                    }
                }
                var ints3 = answer.OrderBy(x => x).ToArray();
                for (int i = 0; i < ints3.Count(); i++)
                {
                    Console.WriteLine(ints3[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 나머지
        internal void Level4Method08()
        {
            try
            {
                int cnt = 10;
                int num = 42;
                int count = 0;
                string str = string.Empty;
                int[] ints = new int[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    string? temp = Console.ReadLine();
                    if (temp == null) continue;
                    int value = Convert.ToInt32(temp);
                    //string remain = (value % num).ToString();
                    //if (!str.Contains(remain))
                    //{
                    //    str += $"{remain},";
                    //}
                    int remain = value % num;
                    ints[i] = remain;

                }
                //string[] arr = str.Split(',');
                var result = ints.Distinct().Count();
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 바구니 뒤집기
        internal void Level4Method09()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                string[] arr = str.Split(' ');
                int n = Convert.ToInt32(arr[0]);
                int m = Convert.ToInt32(arr[1]);
                int[] ints = new int[n];
                for (int i = 0; i < n; i++)
                {
                    ints[i] = i + 1;
                }
                for (int i = 0; i < m; i++)
                {
                    string? tempStr = Console.ReadLine();
                    if (tempStr == null) continue;
                    string[] tempArr = tempStr.Split(' ');
                    int a = Convert.ToInt32(tempArr[0]) - 1;
                    int b = Convert.ToInt32(tempArr[1]) - 1;
                    while (a<=b)
                    {
                        int temp = ints[b];
                        ints[b] = ints[a];
                        ints[a] = temp;
                        a++;
                        b--;

                    }
                    
                }
                for(int i = 0; i < n;i++)
                {
                    Console.Write($"{ints[i]} ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 평균
        internal void Level4Method10()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                int n = Convert.ToInt32(str);
                str = Console.ReadLine();
                if(str==null) return;
                string[] arr = str.Split(" ");
                double[] scores = new double[n];
                for(int i = 0;i < n;i++) scores[i] = Convert.ToDouble(arr[i]);
                double max = scores.Max();
                for (int i = 0; i < n; i++)
                {
                    double temp = scores[i];
                    scores[i] = temp / max * 100;
                }
                Console.WriteLine(scores.Average());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
