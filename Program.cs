﻿namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Harfyaz();
        }
        static void Harfyaz()
        {
            char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            for (int harf = 0; harf < harfler.Length - 14; harf++) Console.Write("{0} ", harfler[harf]);
            Console.WriteLine();
            for (int harf = 15; harf < harfler.Length; harf++) Console.Write("{0} ", harfler[harf]);
        }

    }
}