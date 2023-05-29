namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static int wrongAnswer;
        static void Main(string[] args)
        {

            Console.WriteLine("Adam Asmaca");
            int score = 0;

            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };
            Console.WriteLine("Adam Asmaca");
            ShowCategories(kategoriler);
            Alphabet();
          
            wrongAnswer = 5;
                Draw();
            Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Puan: {0}",score);
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
        static void Alphabet()
        {
            char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            for (int harf = 0; harf < harfler.Length ; harf++) 
            {
                Console.Write("{0} ", harfler[harf]);
                if (harf == harfler.Length / 2) Console.WriteLine("{0} ", harfler[harf]);
            }
        }
        static void ShowCategories(string[] categories)
        {
            int columnCount = 2;
            for (int i = 0; i < categories.Length; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (i == 4  && j == 1) break;
                     Console.Write("{0}- {1}\t", i + j + 1, categories[i]);
                }
                Console.WriteLine();
                i++;
            }
        }
        static void ShowGameName()
        { 
            Console.WriteLine("Adam Asmaca");
        }
        
    }

