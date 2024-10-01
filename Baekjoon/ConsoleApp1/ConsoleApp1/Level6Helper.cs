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
                Level6Method03();

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
        #region 별 찍기 - 7
        internal void Level6Method03()
        {
            try
            {
                //입력값 숫자 타입으로 변환
                string? str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) return;
                int n = Convert.ToInt32(str);

                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                //n = 5일 때, 
                //1, 3, 5, 7. 9, 7, 5, 3, 1
                // 1 : 빈칸 * n-1 + * + 빈칸 * n-1
                // 2 : 빈칸 * 2n -1 + * * 2n-1 + 


                Console.WriteLine(sb.ToString());

            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 팰린드롬인지 확인하기
        internal void Level6Method04()
        {
            try
            {
                //입력값 문재 배열형으로 변환
                string? str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) return;

                int result = 0;
                char[] a = str.ToArray();
                char[] b = a.Reverse().ToArray();
                
                //char 배열로 string 만들기
                if (str == new string(b)) result = 1;

                Console.WriteLine(result);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
