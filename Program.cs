namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static int wrongAnswer;
        static void Main(string[] args)
        {

            Console.WriteLine("Adam Asmaca");
            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };


            wrongAnswer = 5;
                Draw();

                
        }

            static string[] CurrentAppearance()
            {
                if (wrongAnswer == 0)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                XXX "
                    };
                }
                else if (wrongAnswer == 1)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "     X X X       X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "     X X X       X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                 X	",
                    "                XXX "
                    };
                }
                else if (wrongAnswer == 2)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "     X X X       X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "     X X X       X	",
                    "       X         X	",
                    "       X         X	",
                    "       X         X	",
                    "       X         X	",
                    "       X         X	",
                    "       X         X	",
                    "                 X	",
                    "                 X	",
                    "                XXX "
                    };
                }
                else if (wrongAnswer == 3)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "     X X X       X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "     X X X       X	",
                    "       X         X	",
                    "     X X         X	",
                    "   X   X         X	",
                    "  X    X         X	",
                    "       X         X	",
                    "       X         X	",
                    "                 X	",
                    "                 X	",
                    "                XXX"
                    };
                }
                else if (wrongAnswer == 4)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "     X X X       X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "     X X X       X	",
                    "       X         X	",
                    "     X X X       X	",
                    "   X   X   X     X	",
                    "  X    X     X   X	",
                    "       X         X	",
                    "       X         X	",
                    "                 X	",
                    "                 X	",
                    "                XXX "
                    };
                }
                else if (wrongAnswer == 5)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "     X X X       X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "     X X X       X	",
                    "       X         X	",
                    "     X X X       X	",
                    "   X   X   X     X	",
                    "  X    X     X   X	",
                    "       X         X	",
                    "     X X         X	",
                    "   X             X	",
                    "  X              X	",
                    "                XXX "
                    };
                }
                else if (wrongAnswer == 6)
                {
                    return new string[]
                    {
                    "       X X X X X X 	",
                    "       X         X	",
                    "     X X X       X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "    X     X      X	",
                    "     X X X       X	",
                    "       X         X	",
                    "     X X X       X	",
                    "   X   X   X     X	",
                    "  X    X     X   X	",
                    "       X         X	",
                    "     X X X       X	",
                    "   X       X     X	",
                    "  X          X   X	",
                    "                XXX "
                    };
                }

                return new string[0];
            }

            static void Draw()
            {
                string[] currentAppearance = CurrentAppearance();

                for (int i = 0; i < currentAppearance.Length; i++)
                {
                    Console.WriteLine(currentAppearance[i]);
                }
            }
        }
    }

