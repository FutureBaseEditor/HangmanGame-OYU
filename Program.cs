namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };
            Console.WriteLine("Adam Asmaca");
            Alphabet();
            ShowCategories(kategoriler);
            Console.WriteLine("Puan: {0}", score);
        }
        static void Alphabet()
        {
            char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            for (int harf = 0; harf < harfler.Length; harf++)
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
                    if (i == 4 && j == 1) break;
                    Console.Write("{0}- {1}\t", i + j + 1, categories[i]);
                }
                Console.WriteLine();
                i++;

            }
        }

        static void ShowFullCharacter()
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(" ");
            }  //aski bosluk

            for (int i = 0; i < 24; i++)

            {
                Console.Write("_");
            }  // aski yan
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 7; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|"); // sol demir
                for (int k = 0; k < 24; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|"); //sag demir
            }  //aski duz


            for (int i = 1; i <= 8; i++)
            {
                if (i == 1 || i == 8)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = 0; j < 11; j++) // demir
                    {
                        Console.Write("  ");
                    }
                    Console.Write("|");
                }
                else if (i == 2 || i == 7)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("* ");
                    }
                    for (int j = 0; j < 9; j++) // demir
                    {
                        Console.Write("  ");
                    }
                    Console.Write("|");
                }
                else if (i == 4 || i == 5)
                {
                    Console.Write("* ");
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("* ");
                    for (int j = 0; j < 8; j++) // demir
                    {
                        Console.Write("  ");
                    }
                    Console.Write("|");
                }
                else if (i == 3 || i == 6)
                {
                    for (int j = 0; j < 16; j++) // demir
                    {
                        Console.Write("  ");
                    }
                    Console.Write("|");
                }
                Console.WriteLine();
            } //kafa

            for (int i = 0; i < 8; i++)  // vucut
            {
                if (i == 2 || i == 3 || i == 4 || i == 5) // eller
                {
                    for (int j = i - 2; j < 6; j++) // sol el
                    {
                        Console.Write(" ");
                    }
                    Console.Write("/");
                    for (int z = 0; z < i - 2; z++) // omurga
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    for (int x = 0; x < i - 2; x++) // sag el 
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\\");
                    for (int j = i; j < 25; j++) // demir
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");

                    Console.WriteLine();

                } // ellerle omurga
                else
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|"); // sadece omurga

                    for (int j = 0; j < 12; j++) // demir
                    {
                        Console.Write("  ");
                    }
                    Console.Write("|");

                    Console.WriteLine();

                } // sadece omurga

            } // eller ve vucut

            for (int i = 0; i < 7; i++)
            {
                for (int k = i; k < 6; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("/ ");
                for (int j = 0; j < 2 * i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");

                for (int j = i; j < 23; j++) // demir
                {
                    Console.Write(" ");
                }
                Console.Write("|");

                Console.WriteLine();
            } // ayaklar


            for (int j = 0; j < 16; j++) // sadece demir
            {
                Console.Write("  ");
            } // sadece demir
            Console.WriteLine("|");

            for (int j = 0; j < 13; j++) // demir alti bosluk
            {
                Console.Write("  ");
            } // demir alti bosluk

            for (int i = 0; i < 13; i++) // demir alti
            {
                Console.Write("^");
            } // demir alti
            Console.WriteLine(  );
            
        }
    }
}