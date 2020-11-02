using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class User
    {
        public List<List<string>> youField = new List<List<string>>();
        public List<List<string>> battleField = new List<List<string>>();
        public int SumShip = 10;
        public int x = 0;
        public int y = 0;

        public void FillYou()
        {
            youField.Add(new List<string>() { " ", "Р", "Е", "С", "П", "У", "Б", "Л", "I", "К", "А" });
            battleField.Add(new List<string>() { " ", "Р", "Е", "С", "П", "У", "Б", "Л", "I", "К", "А" });
            for (int i = 0; i < 10; i++)
            {
                youField.Add(new List<string>() { i.ToString(), "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
                battleField.Add(new List<string>() { i.ToString(), "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            }
        }
        public void Ranking()
        {
            Random rand = new Random();
            int x = rand.Next(1, 10);
            int y = rand.Next(1, 10);
            int way = rand.Next(1, 10);
            int savex = x;
            int savey = y;
            for (int i = 0; i < 4; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                if (youField[x][y] == "#")
                {
                    youField[x][y] = "1";
                }
                else
                {
                    i--;
                }

            }
            for (int i = 0; i < 3; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                way = rand.Next(1, 4);
                savex = x;
                savey = y;
                if (youField[x][y] == "#")
                {
                    for (int j = 0; j < 1;)
                    {
                        youField[x][y] = "2";
                        while(true)
                        {

                            if (way == 1 && x > 1 && youField[x-1][y] == "#")
                            {
                                x--;
                                break;
                            }
                            else if (way == 2 && x < 11 && youField[x + 1][y] == "#")
                            {
                                x++;
                                break;
                            }
                            else if (way == 3 && y < 11 && youField[x][y + 1] == "#")
                            {
                                y++;
                                break;
                            }
                            else if (way == 4 && y > 1 && youField[x][y + 1] == "#")
                            {
                                y--;
                                break;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        if (youField[x][y] == "#")
                        {
                            youField[x][y] = "2";
                            j++;
                        }
                        else
                        {
                            x = savex;
                            y = savey;
                            way = rand.Next(1, 4);
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                way = rand.Next(1, 4);
                savex = x;
                savey = y;
                if (youField[x][y] == "#")
                {
                    for (int j = 0; j < 1;)
                    {
                        youField[x][y] = "3";
                        
                        if (way == 1)
                        {
                            x--;
                            if (youField[x][y] == "#" && youField[x - 1][y] == "#")
                            {
                                youField[x][y] = "3";
                                x--;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }

                        }
                        else if (way == 2)
                        {
                            x++;
                            if (youField[x][y] == "#" && youField[x + 1][y] == "#")
                            {
                                youField[x][y] = "3";
                                x++;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 3)
                        {
                            y++;
                            if (youField[x][y] == "#" && youField[x][y + 1] == "#")
                            {
                                youField[x][y] = "3";
                                y++;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 4)
                        {
                            y--;
                            if (youField[x][y] == "#" && youField[x][y - 1] == "#")
                            {
                                youField[x][y] = "3";
                                y--;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                way = rand.Next(1, 4);
                savex = x;
                savey = y;
                if (youField[x][y] == "#")
                {
                    for (int j = 0; j < 1;)
                    {
                        youField[x][y] = "4";
                        if (way == 1)
                        {
                            x--;
                            if (youField[x][y] == "#" && youField[x - 1][y] == "#" && youField[x - 2][y] == "#")
                            {
                                youField[x][y] = "4";
                                x--;
                                youField[x][y] = "4";
                                x--;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }

                        }
                        else if (way == 2)
                        {
                            x++;
                            if (youField[x][y] == "#" && youField[x + 1][y] == "#" && youField[x + 2][y] == "#")
                            {
                                youField[x][y] = "4";
                                x++;
                                youField[x][y] = "4";
                                x++;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 3)
                        {
                            y++;
                            if (youField[x][y] == "#" && youField[x][y + 1] == "#" && youField[x][y + 1] == "#")
                            {
                                youField[x][y] = "4";
                                y++;
                                youField[x][y] = "4";
                                y++;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 4)
                        {
                            y--;
                            if (youField[x][y] == "#" && youField[x][y - 1] == "#" && youField[x][y - 1] == "#")
                            {
                                youField[x][y] = "4";
                                y--;
                                youField[x][y] = "4";
                                y--;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
        }
        public void PrintYou()
        {
            Console.Clear();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(youField[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(battleField[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public void RankingYourField(string random)
        {
            for (int l = 0; l != 1;)
            {
                PrintYou();
                Console.WriteLine("1) Re randomed");
                Console.WriteLine("0) Ok");
                random = Console.ReadLine();
                if (random == "1")
                {
                    FillYou();
                    Console.Clear();
                    Ranking();
                }
                else if (random == "0")
                {
                    Console.Clear();
                    PrintYou();
                    break;
                }
            }
        }

    }
    class Pk
    {
        public List<List<string>> youField = new List<List<string>>();
        public int SumShip = 10;

        public void FillPk()
        {
            youField.Add(new List<string>() { " ", "Р", "Е", "С", "П", "У", "Б", "Л", "I", "К", "А" });
            for (int i = 0; i < 10; i++)
            {
                youField.Add(new List<string>() { i.ToString(), "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" });
            }
        }
        public void RankingPk()
        {
            Random rand = new Random();
            int x = rand.Next(1, 10);
            int y = rand.Next(1, 10);
            int way = rand.Next(1, 10);
            int savex = x;
            int savey = y;
            for (int i = 0; i < 4; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                if (youField[x][y] == "#")
                {
                    youField[x][y] = "1";
                }
                else
                {
                    i--;
                }

            }
            for (int i = 0; i < 3; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                way = rand.Next(1, 4);
                savex = x;
                savey = y;
                if (youField[x][y] == "#")
                {
                    for (int j = 0; j < 1;)
                    {
                        youField[x][y] = "2";
                        if (way == 1)
                        {
                            x--;
                        }
                        else if (way == 2)
                        {
                            x++;
                        }
                        else if (way == 3)
                        {
                            y++;
                        }
                        else if (way == 4)
                        {
                            y--;
                        }
                        if (youField[x][y] == "#")
                        {
                            youField[x][y] = "2";
                            j++;
                        }
                        else
                        {
                            x = savex;
                            y = savey;
                            way = rand.Next(1, 4);
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                way = rand.Next(1, 4);
                savex = x;
                savey = y;
                if (youField[x][y] == "#")
                {
                    for (int j = 0; j < 1;)
                    {
                        youField[x][y] = "3";
                        if (way == 1)
                        {
                            x--;
                            if (youField[x][y] == "#" && youField[x - 1][y] == "#")
                            {
                                youField[x][y] = "3";
                                x--;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }

                        }
                        else if (way == 2)
                        {
                            x++;
                            if (youField[x][y] == "#" && youField[x + 1][y] == "#")
                            {
                                youField[x][y] = "3";
                                x++;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 3)
                        {
                            y++;
                            if (youField[x][y] == "#" && youField[x][y + 1] == "#")
                            {
                                youField[x][y] = "3";
                                y++;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 4)
                        {
                            y--;
                            if (youField[x][y] == "#" && youField[x][y - 1] == "#")
                            {
                                youField[x][y] = "3";
                                y--;
                                youField[x][y] = "3";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                x = rand.Next(1, 10);
                y = rand.Next(1, 10);
                way = rand.Next(1, 4);
                savex = x;
                savey = y;
                if (youField[x][y] == "#")
                {
                    for (int j = 0; j < 1;)
                    {
                        youField[x][y] = "4";
                        if (way == 1)
                        {
                            x--;
                            if (youField[x][y] == "#" && youField[x - 1][y] == "#" && youField[x - 2][y] == "#")
                            {
                                youField[x][y] = "4";
                                x--;
                                youField[x][y] = "4";
                                x--;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }

                        }
                        else if (way == 2)
                        {
                            x++;
                            if (youField[x][y] == "#" && youField[x + 1][y] == "#" && youField[x + 2][y] == "#")
                            {
                                youField[x][y] = "4";
                                x++;
                                youField[x][y] = "4";
                                x++;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 3)
                        {
                            y++;
                            if (youField[x][y] == "#" && youField[x][y + 1] == "#" && youField[x][y + 1] == "#")
                            {
                                youField[x][y] = "4";
                                y++;
                                youField[x][y] = "4";
                                y++;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                        else if (way == 4)
                        {
                            y--;
                            if (youField[x][y] == "#" && youField[x][y - 1] == "#" && youField[x][y - 1] == "#")
                            {
                                youField[x][y] = "4";
                                y--;
                                youField[x][y] = "4";
                                y--;
                                youField[x][y] = "4";
                                j++;
                            }
                            else
                            {
                                x = savex;
                                y = savey;
                                way = rand.Next(1, 4);
                            }
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
        }
        public void PrintPk()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(youField[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Program
    {
        static void BatelPk(Pk pk, User you)
        {
            Random rand = new Random();
            int aty = rand.Next(1, 10);
            int atx = rand.Next(1, 10);
            int way = rand.Next(1, 10);
            for (int i = 0; i < 1;)
            {
            Label:
                if (you.youField[atx][aty] == "#")
                {
                    you.youField[atx][aty] = "0";
                    i++;
                }
                else if (you.youField[atx][aty] == "1")
                {
                    you.youField[atx][aty] = "¤";
                    aty = rand.Next(1, 10);
                    atx = rand.Next(1, 10);
                    goto Label;
                }
                else if (you.youField[atx][aty] == "2")
                {
                    you.youField[atx][aty] = "¤";
                    way = rand.Next(1, 4);
                    if (way == 1)
                    {
                        atx--;
                    }
                    else if (way == 2)
                    {
                        atx++;
                    }
                    else if (way == 3)
                    {
                        aty++;
                    }
                    else if (way == 4)
                    {
                        aty--;
                    }
                    if (you.youField[atx][aty] == "¤" && you.youField[atx][aty] == "0")
                    {
                        BatelPk(pk, you);
                    }
                }
            }



        }
        static void BattelYou(User you, Pk computer)
        {

            int perevx;
            int perevy;
            Console.WriteLine("Enter cordinete");
            try
            {
                perevx = int.Parse(Console.ReadLine());
            }
            catch
            {
                perevx = int.Parse(Console.ReadLine());
            }
            try
            {
                perevy = int.Parse(Console.ReadLine());
            }
            catch
            {
                perevy = int.Parse(Console.ReadLine());
            }
            if (perevx == -1)
            {
                computer.SumShip = 0;
                return;
            }
            else if (perevx >= 0 && perevx <= 10)
            {
                you.x = perevx + 1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("These coordinates are not correct " + perevx + you.x);
                BattelYou(you, computer);
            }
            if (perevy >= 0 && perevy <= 10)
            {
                you.y = perevy + 1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("These coordinates are not correct 2");
                BattelYou(you, computer);
            }
            if (you.x >= 11 || you.y >= 11 || you.x == 0 || you.y == 0)
            {
                Console.Clear();
                Console.WriteLine("These coordinates are not correct");
                BattelYou(you, computer);
            }
            else
            {
                if (computer.youField[you.y][you.x] == "#" || computer.youField[you.y][you.x] == "O")
                {
                    Console.Clear();
                    Console.WriteLine("You not catch");
                    you.battleField[you.y][you.x] = "0";
                    you.PrintYou();
                }
                else if (computer.youField[you.y][you.x] == "1")
                {
                    computer.SumShip--;
                    Console.Clear();
                    Console.WriteLine("You killed");
                    you.battleField[you.y][you.x] = "¤";
                    you.PrintYou();
                    BattelYou(you, computer);
                }
                else if (computer.youField[you.y][you.x] == "2")
                {
                    computer.SumShip--;
                    Console.Clear();
                    Console.WriteLine("You catch");
                    you.battleField[you.y][you.x] = "¤";
                    you.PrintYou();
                    BattelYou(you, computer);
                }
                else if (computer.youField[you.y][you.x] == "3")
                {
                    computer.SumShip--;
                    Console.Clear();
                    Console.WriteLine("You catch");
                    you.battleField[you.y][you.x] = "¤";
                    you.PrintYou();
                    BattelYou(you, computer);
                }
                else if (computer.youField[you.y][you.x] == "4")
                {
                    computer.SumShip--;
                    Console.Clear();
                    Console.WriteLine("You catch");
                    you.battleField[you.y][you.x] = "¤";
                    you.PrintYou();
                    BattelYou(you, computer);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("These coordinates are not correct");
                    BattelYou(you, computer);
                }
            }



        }

        static void Battle(Pk pk, User you)
        {
            do
            {
                BatelPk(pk, you);
                pk.PrintPk();
                BattelYou(you, pk);
                if (pk.SumShip <= 0 || you.SumShip <= 0)
                {
                    break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            User you = new User();
            Pk pk = new Pk();
            string random = "1";
            pk.FillPk();
            you.FillYou();
            pk.RankingPk();
            you.RankingYourField(random);
            Battle(pk, you);

            if (pk.SumShip == 0)
            {
                Console.WriteLine("You win");
            }
            else if (you.SumShip == 0)
            {
                Console.WriteLine("You lose");
            }
            else if (pk.SumShip == you.SumShip)
            {
                Console.WriteLine("Nichia");
            }
            else
            {
                Console.WriteLine("Eror");
            }
        }
    }
}