using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePianoMaster
{
    internal class Program
    {
        private static void Octave(int nota)
        {
            char[] whiteKlav = { 'a', 's', 'd', 'f', 'g', 'h', 'j' };
            char[] blackKlav = { 'w', 'e', 't', 'y', 'u' };

            int Octave = saveoct < octaves56.Length ? saveoct : octaves56.Length - 1;

            if (nota >= 0 && nota < whiteKlav.Length + blackKlav.Length)
            {
                int fr = octaves56[Octave][nota];
                LetsSound(fr);
            }
        } 

        static int saveoct;
        static int[][] octaves56 = new int[][]
       
        {
        new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 },
        new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 } 
        };

        public static void Main()
        {
            Console.WriteLine(" >>>>>>>>>>>>>>>>>| PIANO |<<<<<<<<<<<<<<<<<");
            Console.WriteLine();
            Console.WriteLine("Используйте следующие клавиши на клавиатуре для воспроизведения нот:");
            Console.WriteLine();
            Console.WriteLine("  w e   t y u - чёрные клавиши");
            Console.WriteLine(" a s d f g h j - белые клавиши");
            Console.WriteLine();
            Console.WriteLine("Будьте внимательны: не забудьте переключить раскладку клавиатуры на английскую и вводите только строчные буквы (без caps lock)");
            Console.WriteLine("Для переключения октав используйте клавиши: F1 - пятая октава, F2 - шестая октава");
            Console.WriteLine("Чтобы остановить пианино, нажмите клавишу 'Esc'.");

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(intercept: true);

                    if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }

                    if (key.Key == ConsoleKey.F1 || key.Key == ConsoleKey.F2)
                    {
                        saveoct = key.Key - ConsoleKey.F1;
                        Console.WriteLine($"\nПереключение на октаву {saveoct + 5}");
                       
                    }
                    else
                    {
                        PlaySound(key.KeyChar);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(" Вы завершили работу с пианино :) ");
            Console.WriteLine();
        }
        private static void LetsSound(int sound)
        {
            Console.Beep(sound, 400); 
        }

        private static void PlaySound(char keyChar)
        {
            switch (keyChar)
            {
                case 'a':
                    Octave(0);
                    Console.Write(" ♫ ");
                    break;
                case 'w':
                    Octave(1);
                    Console.Write(" ♫ ");
                    break;
                case 's':
                    Octave(2);
                    Console.Write(" ♫ ");
                    break;
                case 'e':
                    Octave(3);
                    Console.Write(" ♫ ");
                    break;
                case 'd':
                    Octave(4);
                    Console.Write(" ♫ ");
                    break;
                case 'f':
                    Octave(5);
                    Console.Write(" ♫ ");
                    break;
                case 't':
                    Octave(6);
                    Console.Write(" ♫ ");
                    break;
                case 'g':
                    Octave(7);
                    Console.Write(" ♫ ");
                    break;
                case 'y':
                    Octave(8);
                    Console.Write(" ♫ ");
                    break;
                case 'h':
                    Octave(9);
                    Console.Write(" ♫ ");
                    break;
                case 'u':
                    Octave(10);
                    Console.Write(" ♫ ");
                    break;
                case 'j':
                    Octave(11);
                    Console.Write(" ♫ ");
                    break;
                default:
                    return;
            }
        }
    }
}