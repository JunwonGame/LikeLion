using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion5
{
    class Program
    {
        static void Main(string[] args)
        {
            //숫자 데이터형식 : 정수와 실수를 다룰 때 사용하는 다양한 타입
            int intergerNum = 10; //정수 데이터
            float floatNum = 3.14f; //단정밀도 실수
            double doubleNum = 3.14159; //배정밀도 실수

            Console.WriteLine(intergerNum);
            Console.WriteLine(floatNum);
            Console.WriteLine(doubleNum);

            //정수 데이터 형식 : 소수점이 없는 숫자를 표현
            int intValue = -100; // 4바이트 크기의 정수
            long longValue = 1234567890L; //8바이트 크기의 정수

            Console.WriteLine(intValue);
            Console.WriteLine(longValue);

            //부호 있는 정수 : 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50; //1바이트 크기
            short signedShort = -32000; //2바이트 크기
            int signedInt = -20000000; //4바이트 크기

            //부호 없는 정수 데이터 형식
            byte unsignedByte = 255; //1바이트 크기
            ushort unsignedShort = 65000; //2바이트 크기
            uint unsignedInt = 4000000000; //4바이트 크기

            //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f; //단정밀도 실수(정밀도 낮음, 메모리 적게사용, 4바이트)
            double doublePrecision = 3.1415926535; //배정밀도 실수(2배로 높음, 8바이트)
            decimal highPrecision = 3.141592653545646546545m; //고정밀도(금융계산, 16바이트)

            //숫자형식의 리터럴 값에 접미사 붙이기
            int integerValue = 100; //기본 정수형(int)
            long longintValue = 100L; //정수형(long)
            float floatValue = 3.14f; //실수형(float)
            double doubleValue = 3.14; //기본 실수형(double)
            decimal decimalValue = 3.14m; //고정밀도 실수형(decimal)

            //문자 데이터 형식 : char 단일 문자를 표현
            char letter = 'A'; //문자 'A' 저장
            char symbol = '#'; //특수 기호 저장
            char number = '9'; //숫자 형태의 문자 저장(문자 '9', 숫자 9 아님)

            //문자열 데이터 형식 : string 여러 문자를 저장
            string greeting = "Hello, World!"; //문자열 저장
            string name = "Alice"; //이름 저장

            //논리 데이터 형식 : bool 참 = 1 거짓 = 0
            bool isRunning = true; //프로그램 실행 상태
            bool isFinished = false; //프로그램 종료 상태

            //변하지 않는 값 상수 : 값이 변경되지 않는 변수를 선언할 때 사용
            const double Pi = 3.14159;
            const int MaxScore = 100; //최대점수

            //닷넷 형식 : 기본 형식의 닷넷 표현, 기본 데이터 형식에 대한 시스템 형식을 제공
            System.Int32 number1 = 123; //int의 닷넷형식
            System.String text = "안녕"; //string의 닷넷형식
            System.Boolean flag = true; //bool의 닷넷형식

            //래퍼 형식 : 기본 데이터 형식을 클래스 형태로 감싸서 객체로 취급하게 만듦
            int number2 = 123;
            string numberAsString = number.ToString(); //정수를 문자열로 변환

            bool flag2 = true;
            string flagAsString = flag.ToString(); //논리값을 문자열로 변환
            
        }

    }
}
