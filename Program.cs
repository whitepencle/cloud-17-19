﻿class Player // 여섯번째
{
    int AT = 10;
    int HP = 50;
    int MAXHP = 100;

    public void PrintHp()
    {
        Console.WriteLine("");
        Console.Write("현재 플레이어의 HP는 ");
        Console.Write(HP);
        Console.WriteLine("입니다.");
        Console.ReadKey();
    }
    public void MaxHeal()
    {
        if (HP >= MAXHP)
        {
            Console.WriteLine("");
            Console.WriteLine("체력이 모두 회복되어있어 회복할 필요가 없습니다.");
            Console.ReadKey();
        }
        else
        {
            HP = MAXHP;
            PrintHp();
        }
        return;
    }

    public void StatusRender() // 일곱번째 
    {
        Console.WriteLine("-------------------------------------------------");
        Console.Write("공격력 : ");
        Console.WriteLine(AT);

        Console.Write("체력 : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MAXHP);
        Console.WriteLine("-------------------------------------------------");


    }
}
class Monster // 여덣번째
{

}

enum STARTSELECT // 네번째
{
    SELECTTOWN,
    SELECTBATTLE,
    NONSELECT,
}


internal class Program // 첫번째
{
    static STARTSELECT StartSelect()
    {


        Console.Clear();
        Console.WriteLine("1. 마을");
        Console.WriteLine("2. 배틀");
        Console.WriteLine("어디로 가시겠습니까?");

        ConsoleKeyInfo CKI = Console.ReadKey(); // 본인이 친 문자를 대응하는 문자로 변경

        Console.WriteLine("");

        switch (CKI.Key) // 조건문
        {
            case ConsoleKey.D1:
                Console.WriteLine("마을로 이동합니다.");
                Console.ReadKey();
                return STARTSELECT.SELECTTOWN;
            case ConsoleKey.D2:
                Console.WriteLine("배틀을 시작합니다.");
                Console.ReadKey();
                return STARTSELECT.SELECTBATTLE;
            default:
                Console.WriteLine("잘못된 선택입니다.");
                Console.ReadKey();
                return STARTSELECT.NONSELECT;
        }

    }

    static void Town(Player _Player) // 두번째
    {
        while (true)
        {
            Console.Clear();
            _Player.StatusRender();
            Console.WriteLine("마을에서 무슨 일을 하시겠습니까?");
            Console.WriteLine("1. 체력을 회복한다.");
            Console.WriteLine("2. 무기를 강화한다.");
            Console.WriteLine("3. 마을을 나간다.");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    _Player.MaxHeal();
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    return;
            }
        }
    }

    static void Battle() // 세번째
    {
        Console.WriteLine("");
        Console.WriteLine("아직 개장하지 않았습니다.");
        Console.ReadKey();
    }

    private static void Main(string[] args)
    {

        Player NewPlayer = new Player();


        while (true) // 다섯번째
        {

            STARTSELECT SelectCheck = StartSelect();

            switch (SelectCheck)
            {
                case STARTSELECT.SELECTTOWN:
                    Town(NewPlayer);
                    break;
                case STARTSELECT.SELECTBATTLE:
                    Battle();
                    break;
            }
        }

    }
}