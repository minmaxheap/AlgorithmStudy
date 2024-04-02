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
                #region 문자열 출력하기
                Console.WriteLine("문자열 출력하기");

                #endregion

                #region a와 b 출력하기
                Console.WriteLine("a와 b 출력하기");
                #endregion


                #region 문자열 반복해서 출력하기
                Console.WriteLine("문자열 반복해서 출력하기");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
