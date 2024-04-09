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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region 문자열 출력하기

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
    }
}
