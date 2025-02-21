using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion4
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열
            string greeting; //문자열 변수를 선언
            greeting = "hello, world!"; //변수에 값을 저장

            //변수의 값을 사용
            Console.WriteLine(greeting); //출력 : hello, world! // 전체 주석하는 방법 : ctrl + / 혹은 ctrl + shift + /


            //변수 선언과 초기화를 한번에 수행
            int score = 100; //정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; //문자열 변수 선언과 초기화

            Console.WriteLine(score); //출력 100
            Console.WriteLine(temperature); //출력 36.5
            Console.WriteLine(city); //출력 Seoul

            //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            int x = 10, y = 20, z = 30; //정수형 변수 x,y,z를 선언하고 초기화

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //상수 사용하기 : 프로그램 내에서 변하지 않는 중요한 값을 정의할 때 사용. 고정된 값으로 실수로 변경되는것을 방지한다.
            const double Pi = 3.14159; // 상수 pi 선언 및 초기화
            const int MaxScore = 100; //정수형 상수 

            //과제 제출
            int att = 16775;
            int maxHp = 78103;
            int criticalDmg = 36;
            int special = 1017;
            int subdue = 41;
            int swiftness = 611;
            int indurance = 22;
            int proficiency = 39;

            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("최대 생명력 : " + maxHp);
            Console.WriteLine("치명 : " + criticalDmg);
            Console.WriteLine("특화 : " + special);
            Console.WriteLine("제압 : " + subdue);
            Console.WriteLine("신속 : " + swiftness);
            Console.WriteLine("인내 : " + indurance);
            Console.WriteLine("숙련 : " + proficiency);

        }
    }
}
