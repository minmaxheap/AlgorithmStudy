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
                Level1Method01();
                Level1Method02();
                Level1Method03();
                Level1Method04();
                Level1Method05();
                Level1Method06();


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
    }
}
