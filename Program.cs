namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adam Asmaca");
            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };
            
            int wrongAnswer = 5;

                 if (wrongAnswer == 1) Wrong1();
            else if (wrongAnswer == 2) Wrong2();
            else if (wrongAnswer == 3) Wrong3();
            else if (wrongAnswer == 4) Wrong4();
            else if (wrongAnswer == 5) Wrong5();
            else if (wrongAnswer == 6) Wrong6();
                 else Begingame();



        }

        static void Begingame()
        {
            string[] Begingame = // 0 yanlış cevap
               {
                 "     X X X X X X 	",
                 "     X         X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "              XXX "
            };

            for (int i = 0; i < Begingame.Length; i++)
            {
                for (int j = 0; j < Begingame[i].Length; j++)
                {
                    Console.Write(Begingame[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Wrong1()
        {
            string[] Wrong1 = // 1 yanlış cevap
            {
                 "     X X X X X X 	",
                 "     X         X	",
                 "   X X X       X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "   X X X       X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "               X	",
                 "              XXX "
            };

            for (int i = 0; i < Wrong1.Length; i++)
            {
                for (int j = 0; j < Wrong1[i].Length; j++)
                {
                    Console.Write(Wrong1[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Wrong2()
        {
            string[] Wrong2 = // 2 yanlış cevap
            {
                 "     X X X X X X 	",
                 "     X         X	",
                 "   X X X       X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "   X X X       X	",
                 "     X         X	",
                 "     X         X	",
                 "     X         X	",
                 "     X         X	",
                 "     X         X	",
                 "     X         X	",
                 "               X	",
                 "               X	",
                 "              XXX "
            };

            for (int i = 0; i < Wrong2.Length; i++)
            {
                for (int j = 0; j < Wrong2[i].Length; j++)
                {
                    Console.Write(Wrong2[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Wrong3()
        {
            string[] Wrong3 = // 3 yanlış cevap
               {
                 "     X X X X X X 	",
                 "     X         X	",
                 "   X X X       X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "   X X X       X	",
                 "     X         X	",
                 "   X X         X	",
                 " X   X         X	",
                 "X    X         X	",
                 "     X         X	",
                 "     X         X	",
                 "               X	",
                 "               X	",
                 "              XXX"
            };

            for (int i = 0; i < Wrong3.Length; i++)
            {
                for (int j = 0; j < Wrong3[i].Length; j++)
                {
                    Console.Write(Wrong3[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Wrong4()
        {
            string[] Wrong4 = // 4 yanlış cevap
            {
                 "     X X X X X X 	",
                 "     X         X	",
                 "   X X X       X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "   X X X       X	",
                 "     X         X	",
                 "   X X X       X	",
                 " X   X   X     X	",
                 "X    X     X   X	",
                 "     X         X	",
                 "     X         X	",
                 "               X	",
                 "               X	",
                 "              XXX "
            };

            for (int i = 0; i < Wrong4.Length; i++)
            {
                for (int j = 0; j < Wrong4[i].Length; j++)
                {
                    Console.Write(Wrong4[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Wrong5()
        {
            string[] Wrong5 = // 5 yanlış cevap
              {
                 "     X X X X X X 	",
                 "     X         X	",
                 "   X X X       X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "   X X X       X	",
                 "     X         X	",
                 "   X X X       X	",
                 " X   X   X     X	",
                 "X    X     X   X	",
                 "     X         X	",
                 "   X X         X	",
                 " X             X	",
                 "X              X	",
                 "              XXX "
            };

            for (int i = 0; i < Wrong5.Length; i++)
            {
                for (int j = 0; j < Wrong5[i].Length; j++)
                {
                    Console.Write(Wrong5[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Wrong6()
        {
            string[] Wrong6 = // 6 yanlış cevap
               {
                 "     X X X X X X 	",
                 "     X         X	",
                 "   X X X       X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "  X     X      X	",
                 "   X X X       X	",
                 "     X         X	",
                 "   X X X       X	",
                 " X   X   X     X	",
                 "X    X     X   X	",
                 "     X         X	",
                 "   X X X       X	",
                 " X       X     X	",
                 "X          X   X	",
                 "              XXX "
            };

            for (int i = 0; i < Wrong6.Length; i++)
            {
                for (int j = 0; j < Wrong6[i].Length; j++)
                {
                    Console.Write(Wrong6[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
