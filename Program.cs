namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";

            for (int harf = 0; harf < harfler.Length - 14; harf++) Console.Write("{0} ", harfler[harf]);
            Console.WriteLine();
            for (int harf = 15; harf < harfler.Length; harf++) Console.Write("{0} ", harfler[harf]);
        }
    }
}