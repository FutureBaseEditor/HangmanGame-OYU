using System.Globalization;

namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowGameName();
            string[] hayvanlar = { "Kedi", "Köpek", "At", "Tavşan", "Leylek", "Deve", "Yarasa", "Sincap", "Sinek", "Karınca" };
            string[] ulkeler = { "Türkiye", "İtalya", "Kanada", "Almanya", "Japonya", "İngiltere", "Rusya", "Fransa", "Meksika", "Brezilya" };
            string[] meslekler = { "Öğretmen", "Doktor", "Mühendis", "Hemşire", "Polis", "Avukat", "İnşaat işçisi", "Dişçi", "Gazeteci", "Bankacı" };
            string[] yemekler = { "Makarna", "Kebap", "Pilav", "Pizza", "Köfte", "Tavuk", "Balık", "Mantı", "Börek", "Salata" };
            string[] sporlar = { "Futbol", "Basketbol", "Voleybol", "Tenis", "Yüzme", "Atletizm", "Boks", "Jimnastik", "Hentbol", "Ragbi" };
            string[] kategoriler = { "Hayvanlar", "Ülkeler", "Meslekler", "Yemekler", "Sporlar" };
            ShowCategories(kategoriler);
            ShowGameName();
        }
        static void ShowCategories(string[] categories)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
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
}