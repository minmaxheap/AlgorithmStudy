using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    /// <summary>
    /// Level2. 조건문
    /// </summary>
    internal class Level2Helper
    {
        internal void Level2Method()
        {
            try
            {
                Level2Method01();
                //Level2Method02();
                //Level2Method03();
                //Level2Method04();
                //Level2Method05();
                //Level2Method06();
                //Level2Method07();
                //Level2Method08);
                //Level2Method09();
                //Level2Method10();
                //Level2Method13();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #region 두 수 비교하기
        internal void Level2Method01()
        {
            try 
            {
                string[] arr = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(arr[0]);
                int b = Convert.ToInt32(arr[1]);

                int c = a - b;
                string str;

                if (c > 0) str = ">";
                else if (c < 0) str = "<";
                else str = "==";

                //if (a>b) str = ">";
                //else if (a<b) str = "<";
                //else str = "==";

                Console.WriteLine(str);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 시험 성적
        internal void Level2Method02()
        {
            try
            {
                string str;
                str = Console.ReadLine();
                int score = Convert.ToInt32(str);

                string grade;
                if (score >= 90) grade = "A";
                else if (score >= 80) grade = "B";
                else if (score >= 70) grade = "C";
                else if (score >= 60) grade = "D";
                else grade = "F";


                Console.WriteLine(grade);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 윤년
        internal void Level2Method03()
        {
            try
            {
                //윤년은 4의 배수 AND (100의 배수가 아닐 때 OR 400의 배수)
                //윤년이면 1, 아니면 0 출력
                string str;
                str = Console.ReadLine();
                int number = Convert.ToInt32(str);
                bool leapFlag = false;
                if(number % 4 == 0 && (number % 100 != 0 || number % 400 == 0))
                {
                    leapFlag = true;
                }
                Console.WriteLine(leapFlag ? 1 : 0);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 사분면 고르기
        internal void Level2Method04()
        {
            try
            {

                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                int quadrant;
                if (x > 0 && y > 0)
                {
                    quadrant = 1;
                }
                else if (x < 0 && y > 0)
                {
                    quadrant = 2;
                }
                else if (x < 0 && y < 0)
                {
                    quadrant = 3;
                }
                else quadrant = 4;
                Console.WriteLine(quadrant);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 사칙연산
        internal void Level2Method05()
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
        internal void Level2Method06()
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
        internal void Level2Method07()
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
        internal void Level2Method08()
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
        internal void Level2Method09()
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
        internal void Level2Method10()
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
        internal void Level2Method12()
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
        internal void Level2Method13()
        {
            try
            {
                Console.WriteLine(@"|\_/|");
                Console.WriteLine(@"|q p|   /}");
                Console.WriteLine(@"( 0 )""""""\");
                Console.WriteLine(@"|""^""`    |");
                Console.WriteLine(@"||_/=\\__|");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
