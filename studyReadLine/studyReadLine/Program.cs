using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님!");

            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요 : ");
            //string input = Console.ReadLine(); //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환
            //Console.WriteLine($"내년에는 {age + 1} 살이 되겠군요!"); //변환된 값 사용
            //Console.WriteLine("내년에는 " + (age + 1) + " 살이 되겠군요.");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);
            

            //과제
            //활동
            //루인 스킬 피해
            //카드 게이지 획득량
            //각성기 피해
            //최대 마나
            //전투 중 마나 회복량
            //비전투 중 마나 회복량
            //이동 속도
            //탈 것 속도
            //운반 속도
            //스킬 재사용 대기시간 감소

            Console.WriteLine("캐릭터 스탯을 입력하세요");

            Console.Write("루인 스킬 피해 : ");
            float ruinSkDmg = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지 획득량 : ");
            float cardGage = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해 : ");
            float ultDmg = float.Parse(Console.ReadLine());

            Console.Write("최대 마나 : ");
            int maxMana = int.Parse(Console.ReadLine());

            Console.Write("전투 중 마나 회복량 : ");
            int gainManaOnFight = int.Parse(Console.ReadLine());

            Console.Write("비전투 중 마나 회복량 : ");
            int gainMana = int.Parse(Console.ReadLine());

            Console.Write("이동속도 : ");
            float moveSpeed = float.Parse(Console.ReadLine());

            Console.Write("탈 것 속도 : ");
            float ridingSpeed = float.Parse(Console.ReadLine());

            Console.Write("운반속도 : ");
            float carryingSpeed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소 : ");
            float reductionSkillCooldown = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("활동");
            Console.WriteLine($"루인 스킬 피해 : {ruinSkDmg}%");
            Console.WriteLine($"카드 게이지 획득량 : {cardGage}%");
            Console.WriteLine($"각성기 피해 : {ultDmg}%");
            Console.WriteLine($"최대 마나 : {maxMana}%");
            Console.WriteLine($"전투 중 마나 회복량 : {gainManaOnFight}%");
            Console.WriteLine($"비전투 중 마나 회복량 : {gainMana}%");
            Console.WriteLine($"이동속도 : {moveSpeed}%");
            Console.WriteLine($"탈 것 속도 : {ridingSpeed}%");
            Console.WriteLine($"운반속도 : {carryingSpeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {reductionSkillCooldown}%");
        }
    }
}
