using System;


namespace Song_decoder
{
    class Program
    {
        public static string SongDecoder(string input)
        {
            string[] decoded = input.Split(new[] { "WUB" }, StringSplitOptions.None);//удаляем все WUB из строки
            string originalSong = "";
            for (int i = 0; i < decoded.Length; i++)
            {
                if (decoded[i] != "")
                {
                    originalSong = originalSong + decoded[i] + " ";
                }
            }
            return originalSong.Trim();//удаляем лишний пробел в конце
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input dubsted string:");
            string input = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(SongDecoder(input));
            Console.ReadKey();
        }
    }
}
