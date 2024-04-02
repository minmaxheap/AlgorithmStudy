using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Lv0
{
    internal class Lv0Helper
    {
        internal void Lv0Method()
        {
            try
            {
                //Lv0Method1();
                //Lv0Method2();
                Lv0Method3();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region 문자열 출력하기

        /// <summary>
        /// https://school.programmers.co.kr/learn/courses/30/lessons/181952
        /// </summary>
        internal void Lv0Method1()
        {
            try
            {
                string s;

                Console.Clear();
                s = Console.ReadLine();
                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region a와 b 출력하기
        /// <summary>
        /// https://school.programmers.co.kr/learn/courses/30/lessons/181951
        /// </summary>
        internal void Lv0Method2()
        {
            try
            {
                string[] s;
                Console.Clear();
                s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0]);
                int b = int.Parse(s[1]);
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 문자열 반복해서 출력하기
        /// <summary>
        /// https://school.programmers.co.kr/learn/courses/30/lessons/181950
        /// </summary>
        internal void Lv0Method3()
        {
            try
            {
                string[] strArr;
                Console.Clear();
                strArr = Console.ReadLine().Split(' ');
                int a = int.Parse(strArr[1]);
                for(int i = 0; i < a; i++)
                {
                    Console.Write(strArr[0]);
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
