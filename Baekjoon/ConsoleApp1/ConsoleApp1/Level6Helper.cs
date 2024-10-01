using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Level6. 심화
    /// </summary>
    internal class Level6Helper
    {
        internal void Run()
        {
            try
            {
                Level6Method01();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 새싹
        internal void Level6Method01()
        {
            try
            {

                string str1 = @"         ,r'""7";
                string str2 = @"r`-_   ,'  ,/";
                string str3 = @" \. "". L_r'";
                string str4 = @"   `~\/";
                string str5 = @"      |";

                Console.WriteLine(str1);
                Console.WriteLine(str2);
                Console.WriteLine(str3);
                Console.WriteLine(str4);
                Console.WriteLine(str5);
                Console.WriteLine(str5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 킹, 퀸, 룩, 비숍, 나이트, 폰
        internal void Level6Method02()
        {
            try
            {
                //입력값 배열로 변환
                string? str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) return;
                string[] inputs = str.Split(' ');

                //배열 초기화
                int[] arr = new int[6] { 1, 1, 2, 2, 2, 8 };
                int[] result = new int[6];
                for (int i = 0; i < inputs.Length; i++)
                {
                    int x = Convert.ToInt32(inputs[i]);
                    //arr[i]-inputs[i]
                    int temp = arr[i] - x;
                    result[i] = temp;
                }
                //배열 공백으로 연결하여 출력
                Console.WriteLine(string.Join(' ', result));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
