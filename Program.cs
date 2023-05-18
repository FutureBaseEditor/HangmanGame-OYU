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

            int wrongAnswer = 0;
            string[] theCurrentAppearanceOfTheCharacter = { "Begingame", "Wrong1", "Wrong2", "Wrong3", "Wrong4", "Wrong5", "Wrong6" };
            string a = theCurrentAppearanceOfTheCharacter[wrongAnswer];

            Draw(a);

        }

        static void Draw(string a)
        {
            string[] Begingame =
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

            string[] Wrong1 =
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

            string[] Wrong2 =
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

            string[] Wrong3 =
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

            string[] Wrong4 =
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

            string[] Wrong5 =
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

            string[] Wrong6 =
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

            string[] currentAppearance;

            switch (a)
            {
                case "Wrong1":currentAppearance     = Wrong1; break;
                case "Wrong2":currentAppearance     = Wrong2; break;
                case "Wrong3":currentAppearance     = Wrong3; break;
                case "Wrong4":currentAppearance     = Wrong4; break;
                case "Wrong5":currentAppearance     = Wrong5; break;
                case "Wrong6":currentAppearance     = Wrong6; break;
                      default:currentAppearance     = Begingame;break;
            }

            for (int i = 0; i < currentAppearance.Length; i++)
            {
                Console.WriteLine(currentAppearance[i]);
            }
        }
    }
}

