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

            ShowGameName();
            Alphabet();
            ShowCategories(kategoriler);

            Console.ReadLine();
            Console.Clear();

            ChooseLetter();

            Console.WriteLine("Puan: {0}", score);
        }

        static char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        static void Alphabet()
        {
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
        static void ShowGameName()
        {
            Console.WriteLine("Adam Asmaca");
        }

        static void ChooseLetter()
        {
            string chosenLetter;
            bool whileStop = false;

            do
            {
                Console.Write("Bir harf seçiniz: ");
                chosenLetter = Console.ReadLine().ToUpper();

                for (int i = 0; i < harfler.Length; i++)
                {
                    if (chosenLetter.Length > 1 || chosenLetter.Length == 0)
                    {
                        Console.WriteLine("Yalnız Bir Harf Giriniz! \n");
                        break;
                    }
                    else if (char.Parse(chosenLetter) == harfler[i])
                    {
                        Console.WriteLine("( {0} ) Harfini Seçtiniz", chosenLetter);
                        whileStop = true;
                        break;
                    }
                    else if (i == harfler.Length - 1)
                    {
                        Console.WriteLine("Lütfen Yalnız Harf Giriniz!  \n");
                    }
                }

            } while (whileStop == false);

        }

    }
}