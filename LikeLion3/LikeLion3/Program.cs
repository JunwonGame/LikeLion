﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미한다.
            int number = 10; //정수형 변수
            double pi = 3.14; //실수형 변수
            char letter = 'A'; //문자 변수 리터럴
            string name = "Alice"; //문자열 변수

            Console.WriteLine(number); //출력 : 10
            Console.WriteLine(pi); // 출력 : 3.14
            Console.WriteLine(letter); // 출력 : A
            Console.WriteLine(name); // 출력 : Alice

            //캐릭터
            //hp : 100
            //att : 56.7
            //캐릭터이름 : ??
            //등급 : S

            int hp = 100;
            float att = 56.7f;
            string characterName = "Junwon";
            char rank = 'S';

            Console.WriteLine();
            Console.WriteLine("캐릭터");
            Console.WriteLine("hp : " + hp);
            Console.WriteLine("att : " +att);
            Console.WriteLine("캐릭터이름 : " + characterName);
            Console.WriteLine("등급 : " + rank);
        }
    }
}
