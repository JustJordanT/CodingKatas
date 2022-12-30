namespace CodingKata.Bowling.Core
{
    public class Game
    {
        public static List<int> Score { get; set; } = new List<int>();
        public static int Turns { get; set; } = 10;
        public static int Pins { get; set; } = 10;
        private bool IsGameOver { get; }
        public static int CurrentRoll1 { get; private set; }
        public static int CurrentRoll2 { get; private set; }
        public static int strikeHolder { get; private set; }
    
        public static int GameInit()
        {
            for (var i = 0; i < Turns; i++)
            {
                RollOne();
                if (CurrentRoll1 == 10)
                {
                    strikeHolder = 10;
                }
                
                Score.Add(CurrentRoll1);
                Pins -= CurrentRoll1;
                RollTwo();
                // strikeHolder == 10 ? Score.Insert(i, strikeHolder + CurrentRoll1) : Score.Insert(i,CurrentRoll2 + CurrentRoll1);
                
                // Console.WriteLine($"Score: {Score[i]}");
            }

            return Score.Sum();
        }

        public static void RollOne()
        {
            var rnd = new Random();
            var value = rnd.Next(Pins);
            Console.WriteLine($"Roll - {value}");
            CurrentRoll1 += value;
        }
        public static void RollTwo()
        {
            var rnd = new Random();
            var value = rnd.Next(Pins);
            Console.WriteLine($"Roll - {value}");
            CurrentRoll2 += value;
        }
    }
}