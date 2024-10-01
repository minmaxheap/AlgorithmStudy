using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Level5. 문자와 문자열
    /// </summary>
    internal class Level5Helper
    {
        internal void Run()
        {
            try
            {
                Level5Method07();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 문자와 문자열
        internal void Level5Method01()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                string? str2 = Console.ReadLine();
                if (str2 == null) return;
                int num = Convert.ToInt32(str2);
                char[] arr = str.ToCharArray();
                Console.WriteLine(arr[num - 1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 단어 길이 재기
        internal void Level5Method02()
        {

            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;

                Console.WriteLine(str.Length);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 문자열
        internal void Level5Method03()
        {
            try
            {
                string? tmep = Console.ReadLine();
                if (tmep == null) return;
                int t = Convert.ToInt32(tmep);
                char[,] arr = new char[t, 2];
                for (int i = 0; i < t; i++)
                {
                    string? str = Console.ReadLine();
                    if (str == null) continue;
                    char first = str.First();
                    char last = str.Last();
                    arr[i, 0] = first;
                    arr[i, 1] = last;

                }
                for (int j = 0; j < t; j++)
                {
                    Console.WriteLine($"{arr[j, 0]}{arr[j, 1]}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 아스키 코드
        internal void Level5Method04()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                Console.WriteLine($"{Convert.ToInt32(str[0])}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 숫자의 합
        internal void Level5Method05()
        {
            try
            {

                string? str = Console.ReadLine();
                string? str2 = Console.ReadLine();

                if (str == null || str2 == null) return;

                int a = Convert.ToInt32(str);
                int c = 0;

                for (int i = 0; i < a; i++)
                {
                    int temp = Convert.ToInt32(str2.Substring(i, 1));

                    c += temp;

                }

                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 알파벳 찾기
        internal void Level5Method06()
        {
            try
            {
                string? str = Console.ReadLine();

                if (str == null) return;

                int a = Convert.ToInt32('a');
                int z = Convert.ToInt32('z');
                string result = "";

                for (int i = a; i <= z; i++)
                {

                    if (str.Contains(Convert.ToChar(i)))
                    {

                        result += $"{str.IndexOf(Convert.ToChar(i))} ";
                    }
                    else result += "-1 ";

                }

                Console.WriteLine(result.TrimEnd());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 문자열 반복
        internal void Level5Method07()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                int num = Convert.ToInt32(str);
                string[] arr2 = new string[num];
                for (int i = 0; i < num; i++)
                {
                    str = Console.ReadLine();
                    if (str == null) return;
                    string[] arr = str.Split(' ');
                    int cnt = Convert.ToInt32(arr[0]);
                    string str2 = arr[1];

                    for(int j = 0; j < str2.Length; j++)
                    {
                        char a = str2[j];
                        for(int k = 0; k< cnt; k++)
                        {
                            arr2[i] += $"{a.ToString()}";

                        }
                    }

                }
                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine(arr2[i]);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 단어의 개수
        internal void Level5Method08()
        {
            try
            {
                string str = Console.ReadLine();
                if(str == null) return;
                string[] arr = str.Split(' ');
                int cnt = 0;
                for(int i =0; i<arr.Length; i++)
                {
                    if (!string.IsNullOrWhiteSpace(arr[i]))
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
        #region 상수
        internal void Level5Method09()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                string[] arr = str.Split(' ');

                char[] arr1 = arr[0].ToCharArray();
                char[] arr2 = arr[1].ToCharArray();

                char[] arr1R = arr1.Reverse().ToArray();
                char[] arr2R = arr2.Reverse().ToArray();

                string str1 = string.Concat(arr1R);
                string str2 = string.Concat(arr2R);

                int num1 = Convert.ToInt32(str1);
                int num2 = Convert.ToInt32(str2);

                Console.WriteLine(num1 > num2 ? num1 : num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 다이얼
        internal void Level5Method10()
        {
            try
            {
                string? str = Console.ReadLine();
                if (str == null) return;
                string[] arr = new string[10];
                for (int i = 0; i < arr.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            arr[i] = ""; 
                            break;
                        case 1:
                            arr[i] = "ABC";
                            break;
                        case 2:
                            arr[i] = "DEF";
                            break;
                        case 3:
                            arr[i] = "GHI";
                            break;
                        case 4:
                            arr[i] = "JKL";
                            break;
                        case 5:
                            arr[i] = "MNO";
                            break;
                        case 6:
                            arr[i] = "PQRS";
                            break;
                        case 7:
                            arr[i] = "TUV";
                            break;
                        case 8:
                            arr[i] = "WXYZ";
                            break;
                        case 9:
                            break;
                        default:
                            break;

                    }
                }
                char[] charArr = str.ToCharArray();
                int result = 0;
                for (int i = 0; i < charArr.Length; i++)
                {
                    char s = charArr[i];
                    var temp = Array.FindIndex(arr,(x) => x.Contains(s));
                    result += (temp + 1) + 1;
                }
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 그대로 출력하기
        internal void Level5Method11()
        {
            try
            {
                while (true)
                {
                    string? str = Console.ReadLine();
                    Console.WriteLine(str);
                    if (string.IsNullOrEmpty(str))
                        return;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
