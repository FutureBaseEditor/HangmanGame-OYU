namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adam Asmaca");
            int score = 0;
            Console.WriteLine("Puan: {0}",score);
            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };
            ShowCategories(kategoriler);
            ChooseCategory(kategoriler);
            
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
        static int choosedCategory;
        static void ChooseCategory(string[] categories)
        {
             while (choosedCategory < 1 || choosedCategory > categories.Length)
             { 
                Console.Write("Kategori Seçiniz: ");        
                choosedCategory = int.Parse(Console.ReadLine());
             }
        }
    }
}