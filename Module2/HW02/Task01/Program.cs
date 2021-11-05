using System;

namespace Task01
{
    public class ConsolePlate
    {
        char _plateChar;
        ConsoleColor _plateColor = ConsoleColor.White;
        ConsoleColor _plateBackColor = ConsoleColor.Black;

        public ConsolePlate()
        {
            _plateChar = 'A';
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor plateBackColor)
        {
            this.PlateChar = plateChar;
            this.PlateColor = plateColor;
            this.PlateBackColor = plateBackColor;
        }
        public char PlateChar
        {
            set
            {
                if (value >= 'A' && value <= 'Z')
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
            get
            {
                return _plateChar;
            }
        }
        public ConsoleColor PlateColor
        {
            set
            {
                _plateColor = value;
            }
            get
            {
                return _plateColor;
            }
        }
        public ConsoleColor PlateBackColor
        {
            set
            {
                _plateBackColor = value;
            }
            get
            {
                return _plateBackColor;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate first = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            ConsolePlate second = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Cyan);
            int.TryParse(Console.ReadLine(), out int n);
            for (int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    if((i + j) % 2 == 0)
                    {
                        Console.ForegroundColor = first.PlateColor;
                        Console.BackgroundColor = first.PlateBackColor;
                        Console.Write(first.PlateChar);
                    }
                    else
                    {
                        Console.ForegroundColor = second.PlateColor;
                        Console.BackgroundColor = second.PlateBackColor;
                        Console.Write(second.PlateChar);
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }
    }
}
