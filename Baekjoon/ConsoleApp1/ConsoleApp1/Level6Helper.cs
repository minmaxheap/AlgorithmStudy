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

                // 위쪽 삼각형 출력
                for (int i = 1; i <= n; i++)
                {
                    // 공백 출력
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    // 별 출력
                    for (int k = 1; k <= (2 * i - 1); k++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine(); // 줄바꿈
                    //Console.Write("\n");
                }

                // 아래쪽 삼각형 출력
                for (int i = n - 1; i >= 1; i--)
                {
                    // 공백 출력
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    // 별 출력
                    for (int k = 1; k <= (2 * i - 1); k++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine(); // 줄바꿈
                    //Console.Write("\n");
                }


                //※ 오른쪽 공백은 굳이 주지 않아도 된다.
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
        #region 단어 공부
        internal void Level6Method05()
        {
            try
            {
                //입력값 문재 배열형으로 변환
                string? str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) return;

                char[] arr = str.ToUpper().ToArray();

                string result = "?";
                int num = 0;
                Dictionary<char, int> dic = new Dictionary<char, int>();
                for (int i = 0; i< arr.Length; i++)
                {
                    char c = arr[i];
                    if(dic.ContainsKey(c))
                    {
                        dic[c] = dic[c] + 1;
                    }
                    else
                    {
                        dic.Add(c, 1);
                    }

                }
                // 최댓값과 해당 키 찾기
                char maxChar = ' ';
                int maxCount = 0;
                bool isDuplicate = false; // 중복 여부 확인
                foreach(var pair in dic) 
                {
                    if(pair.Value > maxCount)
                    {
                        maxCount = pair.Value;
                        maxChar = pair.Key;
                        isDuplicate = false; //새로운 최댓값이 발견되면 중복 초기화
                    }
                    else if(pair.Value == maxCount)
                    {
                        isDuplicate = true; //중복 발견
                    }
                }
                
                if(isDuplicate)
                {
                    Console.WriteLine(result); //중복일 경우
                }
                else
                    Console.WriteLine(maxChar); //최댓값을 가진 문자 출력


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 크로아티아 알파벳
        internal void Level6Method06()
        {
            try
            {

                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) return;
                char[] arr = str.ToCharArray();
                string[] croatiaArr = new string[8] { "č", "ć", "dž", "đ", "lj", "nj", "š", "ž" };
                string[] croatiaArr2 = new string[8] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

                int count = 0; // 크로아티아 알파벳 개수
                for (int i = 0; i < arr.Length; i++)
                {
                    // 두 글자 또는 세 글자로 치환 확인
                    if (i < arr.Length - 1 && croatiaArr2.Contains($"{arr[i]}{arr[i + 1]}"))
                    {
                        count++; // 크로아티아 알파벳 발견
                        i++; // 두 글자 건너뛰기
                    }
                    else if (i < arr.Length - 2 && croatiaArr2.Contains($"{arr[i]}{arr[i + 1]}{arr[i + 2]}"))
                    {
                        count++; // 크로아티아 알파벳 발견 (세 글자)
                        i += 2; // 세 글자 건너뛰기
                    }
                    else
                    {
                        count++; // 일반 알파벳 발견
                    }
                }


                Console.WriteLine(count); // 총합 출력

/*                // 크로아티아 알파벳을 대체 문자로 치환
                str = str.Replace("dz=", "D")
                         .Replace("c=", "C")
                         .Replace("c-", "C")
                         .Replace("d-", "D")
                         .Replace("lj", "L")
                         .Replace("nj", "N")
                         .Replace("s=", "S")
                         .Replace("z=", "Z");

                // 남은 문자 수 세기
                Console.WriteLine(str.Length);*/
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 그룹 단어 체커
        internal void Level6Method07()
        {
            try
            {
                //그룹 단어 = 존재하는 모든 문자에 대해서, 각 문자가 연속해서 나타나는 경우

                //입력 :
                //첫째 줄 : 단어의 개수 N
                //둘째 줄부터 N개의 줄 : 단어 들어옴
                //입력 조건 : 알파벳 소문자, 중복되지 않음, 길이 최대 100

                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) return;
                int n = Convert.ToInt32(str);
                int groupWordCount = 0;

                for (int i = 0; i < n; i++)
                {
                    string word = Console.ReadLine();
                    bool isGroupWord = true;
                    HashSet<char> seenChars = new HashSet<char>();
                    char prevChar = word[0];
                    foreach (char c in word)
                    {
                        if(c!=prevChar && seenChars.Contains(c))
                        {
                            isGroupWord = false;
                            break;
                        }
                        seenChars.Add(c);
                        prevChar = c;
                    }
                    if(isGroupWord)
                    {
                        groupWordCount++;
                    }
                }

                //출력 : 
                //그룹 단어의 개수
                Console.WriteLine(groupWordCount);

                string chatGptHint = @"

단어 검증 로직의 오류:

현재 코드는 문자의 등장 횟수를 세는 arr.Count(x => x == temp1)로 중복된 문자를 찾고 있지만, 이는 그룹 단어의 조건을 정확히 검증하지 못합니다. 단순히 중복 여부만 확인하는 것이 아니라, 중복된 문자가 연속해서 등장하는지를 확인해야 합니다.
중복된 문자가 등장했을 때 prevCount == 0과 isSame을 검사하는 방식은 직관적이지 않고, 불필요하게 복잡합니다. 
이미 이전에 등장한 문자를 기록하고, 연속성을 확인하는 방식으로 단순화할 수 있습니다.

입력 처리:
char[] filterArr = arr.Where((x, index) => index < j).ToArray();로 이전 문자들을 배열로 필터링하는 과정이 불필요하게 복잡합니다. 이전 문자가 무엇인지만 추적하면 되므로 리스트나 배열을 매번 새로 만드는 대신, 간단히 비교할 수 있습니다.";

                //※ 직전 문자를 arr[i-1] 값으로 판단할 수도 있지만, prevChar = c로 계속 바꿔가면서 보여주면 더 직관적이다. 
                //※ 이미 비교한 문자는 이렇게 해쉬 set. 왜냐면 중복된 문자는 안 넣으니까. 
                //※ 이미 나왔던 문자인지는 Contains로 알 수 있지
                //※ 그룹 문자가 아니면 b
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        #region 너의 평점은
        internal void Level6Method08()
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
