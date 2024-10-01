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
    }
}
