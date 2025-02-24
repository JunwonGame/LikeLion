using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task0221
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임스토리1

            Console.WriteLine("데이터 로딩중.");
            Console.WriteLine("□□□□□□□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear(); //콘솔 화면 지우기
            Console.WriteLine("데이터 로딩중..");
            Console.WriteLine("■□□□□□□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중...");
            Console.WriteLine("■■□□□□□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중.");
            Console.WriteLine("■■■□□□□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중..");
            Console.WriteLine("■■■■□□□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중...");
            Console.WriteLine("■■■■■□□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중.");
            Console.WriteLine("■■■■■■□□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중..");
            Console.WriteLine("■■■■■■■□□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중...");
            Console.WriteLine("■■■■■■■■□□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중.");
            Console.WriteLine("■■■■■■■■■□");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();
            Console.WriteLine("데이터 로딩중..");
            Console.WriteLine("■■■■■■■■■■");
            Console.Clear();
            Console.WriteLine("게임 로딩 성공");
            Thread.Sleep(1000); //1000이 1초
            Console.Clear();

            //스토리 시작
            Console.WriteLine("엔터를 치면 스토리가 시작됩니다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("세상이 창조되었다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그리고 용사는 마왕을 물리치기로 했다.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("그러나 마왕이 승리했고 세상은 멸망했다.");
            Console.ReadLine();
            Console.Clear();

            //엔딩 크레딧 씬
            string[] credits = {
            "CREDITS",
            "제작 : 정준원",
            "기획 : 정준원",
            "프로그래밍 : 정준원",
            "스토리 작가 : 정준원",
            "특별 감사 : 멋쟁이사자처럼",
            "감사합니다!",
            "THE END"
            };
            int consoleHeight = Console.WindowHeight; // 콘솔 창 높이


            for (int i = 0; i < credits.Length + consoleHeight; i++)
            {
                Console.Clear(); // 콘솔 창 지우기

                // 크레딧 텍스트 출력
                for (int j = 0; j < credits.Length; j++)
                {
                    if (i - j >= 0 && i - j < consoleHeight)
                    {
                        Console.SetCursorPosition(Console.WindowWidth / 2, i - j);
                        Console.WriteLine(credits[credits.Length -1 - j]);
                    }
                }

                Thread.Sleep(500); // 스크롤 딜레이

            }
        }
    }
}
