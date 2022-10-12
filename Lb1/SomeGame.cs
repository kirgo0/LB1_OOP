using System;

namespace Lb1
{
    public enum Status { Win, Lose }
    public class SomeGame
    {
        private Random random = new Random();
        public static int matchIndex { set; get; }
        
        private GameAccount p1, p2;
        
        public SomeGame(GameAccount p1, GameAccount p2)
        {
            matchIndex = new Random().Next(0,100);
            this.p1 = p1;
            this.p2 = p2;
        }

        public void CreateMatch()
        {
            matchIndex++;
            int matchRating = random.Next(5,25);
            if (matchRating < 0) throw new Exception("Rating cannot be less then 0");
            if (random.Next(0,10) > 5)
            {
                Console.WriteLine();
                p1.WinGame(p2.UserName,matchRating);
                p2.LoseGame(p1.UserName,matchRating);
            }
            else
            {
                p2.WinGame(p1.UserName,matchRating);
                p1.LoseGame(p2.UserName,matchRating);
            }
        }
    }
}