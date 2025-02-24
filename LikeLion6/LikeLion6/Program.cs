using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////---이진수를 정수로 변환
            //Console.WriteLine("2진수를 입력하세요.");
            //string binaryInput = Console.ReadLine(); //문자열 입력받는다.
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

            ////---정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2);//10진수 -> 2진수

            //Console.WriteLine($"입력한 이진수 : {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            ////---var를 사용하여 변수 선언
            //var name = "Alice"; //문자열로 추론
            //var age = 15; //정수로 추론
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 학생 : {isStudent}");

            ////---default 키워드를 사용한 기본값 설정
            //int defaultInt = default; //기본값 0
            //string defaultString = default; //기본값 null
            //bool defaultBool = default; //기본값 false

            //Console.WriteLine($"정수 기본값 : {defaultInt}");
            //Console.WriteLine($"문자열 기본값 : {defaultString}");
            //Console.WriteLine($"논리값 기본값 : {defaultBool}");

            ////---연산자

            ////산술연산자
            //int a = 5, b = 3;
            //int addiction = a + b; //덧셈 산술 연산자
            //int subtraction = a - b; //뺄셈
            //int multiplication = a * b; //곱셈
            //int division = a / b; //나눗셈
            //int modifier = a % b; //나머지

            ////단항연산자 -> 피연산자 하나에 적용
            //int number = 5;
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            //bool flag = true;
            //Console.WriteLine(!flag); //false
            //Console.WriteLine(!flag);

            //int num = 12;
            //int result = ~num; // ~ 비트보수연산자 : 각 비트를 반전시킴 (0은 1로 1은 0으로)
            ////결과는 피연산자의 보수 표현에서 1을 더하고 -를 붙인 값과 동일함 -(x+1) (-1을 뺀값과 동일함)
            //Console.WriteLine($"원래 값 : {num}, 바뀐값 : {result}"); // 00001010 => 11110101 = -11
            ///*
            // ~ 연산자는 정수 형식(int, uint, long, ulong, short, ushort, byte, sbyte)에만 적용할 수 있습니다.
            //부호 있는 정수(int, long, short, sbyte)의 경우, 결과는 음수일 수 있습니다.
            //부호 없는 정수(uint, ulong, ushort, byte)의 경우, 결과는 항상 양수입니다.
            // */

            ////변환 연산자 () 캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi; //실수형 => 정수형으로 변환

            //int attdmg = 10;
            //int skdmg = 100;
            //int runedmg = 50;
            //int totdmg = attdmg + skdmg + runedmg;
            //float average = 0.0f;
            //average = (float)totdmg / 3; 

            //Console.WriteLine(integerPi); //3

            ////문자열 연결 연산자 +
            //string firstName = "jung";
            //string lastName = "junwon";
            //Console.WriteLine(firstName + " " + lastName);

            ////할당 연산자 = += -= *= /= %=; 값을 변수에 저장
            //int k = 10;
            //k += 5; // 15

            ////증감 연산자 ++ --
            //int c = 3;
            //c++; //후위 증가 
            //--c; //전위 감소

            //관계형 연산자 == != < > <= >=; 두 값을 비교하여 관계 평가

            //1번 문제
            Console.WriteLine("국어 점수를 입력하세요");
            String input = Console.ReadLine();
            int KorScore = Int32.Parse(input);

            Console.WriteLine("영어 점수를 입력하세요");
            input = Console.ReadLine();
            int EngScore = Int32.Parse(input);

            Console.WriteLine("수학 점수를 입력하세요");
            input = Console.ReadLine();
            int MathScore = Int32.Parse(input);

            int sum = KorScore + EngScore + MathScore;
            float averageScore = (float)sum / 3.0f;


            Console.WriteLine($"당신의 평균 점수는 {averageScore.ToString("F2")} 입니다.");

            //2번 문제

            Console.WriteLine("정수를 입력하세요");
            String userInput = Console.ReadLine();
            int originNum = Int32.Parse(userInput);
            int bitwiseNum = ~originNum;

            Console.WriteLine($"원래의 값 : {originNum}, 비트반전 연산 값 : {bitwiseNum}");
        }
    }
}
