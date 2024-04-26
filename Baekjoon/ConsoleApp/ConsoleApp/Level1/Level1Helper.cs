using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lv0
{
    /// <summary>
    /// Level1. 입출력과 사칙연산
    /// </summary>
    internal class Level1Helper
    {
        internal void Level1Method()
        {
            try
            {
                //Level1Method01();
                //Level1Method02();
                //Level1Method03();
                //Level1Method04();
                //Level1Method05();
                //Level1Method06();
                //Level1Method07();
                //Level1Method08);
                //Level1Method09();
                Level1Method10();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region a+b 출력하기
        /// <summary>
        /// https://www.acmicpc.net/problem/1000
        /// </summary>
        internal void Level1Method01()
        {
            try
            {
                string[] arr;

                Console.Clear();
                arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);
                Console.WriteLine(a+b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region a-b 출력하기
        internal void Level1Method02()
        {
            try
            {
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);
                Console.WriteLine(a-b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region a*b 출력하기
        internal void Level1Method03()
        {
            try
            {
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);
                Console.WriteLine(a*b);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region a/b 출력하기
        internal void Level1Method04()
        {
            try
            {
                //정수 나눗셈 규칙: C#에서 두 정수형 변수를 나눌 때, 결과는 소숫점 값이 있더라도 반드시 정수(int) 형태로 나오게 된다. 
                //즉, 소숫점 이하 값은 버려지고, 정수 부분만 남게 된다. 이러한 동작은 "정수 나눗셈"이라고도 불린다.

                string[] arr;
                arr = Console.ReadLine().Split(' ');
                double a = Convert.ToDouble(arr[0]);
                double b = Convert.ToDouble(arr[1]);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 사칙연산
        internal void Level1Method05()
        {
            try
            {
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);
                Console.WriteLine(a+b);
                Console.WriteLine(a-b);
                Console.WriteLine(a*b);
                Console.WriteLine(a/b);
                Console.WriteLine(a%b);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region ??!
        internal void Level1Method06()
        {
            try
            {
                string str;
                str = Console.ReadLine();
                Console.WriteLine($"{str}??!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 1998년생인 내가 태국에서는 2541년생?!
        internal void Level1Method07()
        {
            try
            {
                //2541-1998을 뺀 값이 불기연도와 서기연도의 차이니까, 불기연도가 주어지면 거기서 그 값을 빼면 된다.
                string str;
                str = Console.ReadLine();
                int boolki = Convert.ToInt32(str);
                Console.WriteLine($"{boolki-543}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 나머지
        internal void Level1Method08()
        {
            try
            {
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);
                int c = Convert.ToInt32(arr[2]);

                //첫째 줄에(A+B)% C, 둘째 줄에((A% C) +(B % C))% C, 셋째 줄에(A×B)% C, 넷째 줄에((A% C) × (B % C))% C를 출력한다.
                Console.WriteLine((a + b) % c);
                Console.WriteLine(((a % c) + (b % c)) % c);
                Console.WriteLine((a * b) % c);
                Console.WriteLine(((a % c) * (b % c)) % c);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 곱셈
        internal void Level1Method09()
        {
            try
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();

                int int1 = Convert.ToInt32(str1);
                int int2 = Convert.ToInt32(str2);

                int a = int2 / 100;
                int b = (int2 % 100) / 10;
                int c = int2 % 10;
                Console.WriteLine(int1 * c);
                Console.WriteLine(int1 * b);
                Console.WriteLine(int1 * a);
                Console.WriteLine(int1 * int2);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 꼬마 정민
        internal void Level1Method10()
        {
            try
            {
                //문제 조건을 잘 보고 풀기, 정수라는 조건이 없는데 자꾸 int로 변환해서 틀림
                string[] arr;
                arr = Console.ReadLine().Split(' ');
                /*                double a = Convert.ToDouble(arr[0]);
                                double b = Convert.ToDouble(arr[1]);
                                double c = Convert.ToDouble(arr[2]);*/
                double[] ints = arr.Select(s => Convert.ToDouble(s)).ToArray();
                Console.WriteLine(ints.Sum());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 고양이
        internal void Level1Method12()
        {
            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 개
        internal void Level1Method13()
        {
            try
            {


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
