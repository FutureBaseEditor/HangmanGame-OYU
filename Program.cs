﻿namespace HangmanGame_O_YU_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adam Asmaca");
            Alphabet();
        }
        static void Alphabet()
        {
            char[] harfler = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
            for (int harf = 0; harf < harfler.Length ; harf++) 
            {
                if (harf == harfler.Length / 2) Console.WriteLine("{0} ", harfler[harf]);
                else Console.Write("{0} ", harfler[harf]);
            }
            
        }
    }
}