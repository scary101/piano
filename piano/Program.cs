 namespace piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[11];

            Console.WriteLine("ПИАНИНО"+
                "\n 1 октава = 12 клавиш:" +
                "\n W E T Y U - черные" +
                "\n A S D F G H J - белые" +
                "\n На выбор есть 6 октав:" +
                "\n F1. Big Octave" +
                "\n F2. Small Octave" +
                "\n F3. First Octave" +
                "\n F4. Second Octave" +
                "\n F5. Third Octave" +
                "\n F6. Fourth Octave" +
                "\n Esc. Leave Piano" );
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);
                a = octava(a, key);
                vivod(a, key);
                if(key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Вы вышли из программы");
                    break;
                }
            }
        }


        static int[] octava(int[] a, ConsoleKeyInfo key)
        {
            int[] BigOctave = new int[] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
            int[] SmallOctave = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] FirstOctave = new int[] { 261,277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
            int[] SecondOctave = new int[] { 523,554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] ThirdOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] FourthOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            switch(key.Key)
            {
                case ConsoleKey.F1:
                    Console.WriteLine("BigOctave");
                    a = BigOctave;
                    break;
                case ConsoleKey.F2:
                    Console.WriteLine("SmallOctave");
                    a = SmallOctave;
                    break;
                case ConsoleKey.F3:
                    Console.WriteLine("FirstOctave");
                    a = FirstOctave;
                    break;
                case ConsoleKey.F4:
                    Console.WriteLine("SecondOctave");
                    a = SecondOctave;
                    break;
                case ConsoleKey.F5:
                    Console.WriteLine("ThirdOctave");
                    a = ThirdOctave;
                    break;
                case ConsoleKey.F6:
                    Console.WriteLine("FourthOctave");
                    a = FourthOctave;
                    break;
                    
            }
            return a;
        }
        
        
        static void vivod(int[] a, ConsoleKeyInfo key)
        {
            
            if ((key.Key == ConsoleKey.A))
            {
                Console.Beep(a[0], 150);
                Console.Clear();

            }
            else if ((key.Key == ConsoleKey.W))
            {
                Console.Beep(a[1], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.S))
            {
                Console.Beep(a[2], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.E))
            {
                Console.Beep(a[3], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.D))
            {
                Console.Beep(a[4], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.F))
            {
                Console.Beep(a[5], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.T))
            {
                Console.Beep(a[6], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.G))
            {
                Console.Beep(a[7], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.Y))
            {
                Console.Beep(a[8], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.H))
            {
                Console.Beep(a[9], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.U))
            {
                Console.Beep(a[10], 150);
                Console.Clear();
            }
            else if ((key.Key == ConsoleKey.J))
            {
                Console.Beep(a[11], 150);
                Console.Clear();
            }
        }
    }
}