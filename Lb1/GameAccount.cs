using System;
using System.Collections.Generic;

namespace Lb1
{
    public class GameAccount
    {
        public string UserName { get; }
        private int Rating { set; get; }
        private List<MatchResult> UserCareer = new List<MatchResult>();

        public GameAccount(string userName)
        {
            this.UserName = userName;
        }
        public void WinGame(string opponentName, int matchRating)
        {
            Rating += matchRating;
            UserCareer.Add(new MatchResult(SomeGame.matchIndex, opponentName,matchRating,Status.Win));
        }
        
        public void LoseGame(string opponentName, int matchRating)
        {
            Rating -= matchRating;
            if (Rating < 1) Rating = 1;
            UserCareer.Add(new MatchResult(SomeGame.matchIndex, opponentName,matchRating,Status.Lose));
        }

        public void GetStats()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Profile of player " + UserName);
            Console.WriteLine("Count of matches: " + UserCareer.Count);
            Console.WriteLine("Rating: " + Rating + "\nMatch List:");
            foreach (var matchResult in UserCareer)
            {
                Console.WriteLine("Match index: " + matchResult.matchIndex);
                Console.Write("Your opponent: " + matchResult.opName);
                Console.Write(" | Match Rating: " + matchResult.matchRating);
                Console.Write(" | You ");
                if (matchResult._pStatus == Status.Lose)
                {
                    Console.Write("Lose");
                }
                else
                {
                    Console.Write("Win");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==========================================");
        }
    }
}