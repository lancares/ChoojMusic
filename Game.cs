using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancares
{
    enum PhaseName
    {
        TrackPlaying,
        Rating,
        Summary
    };
    class GameSession
    {
        public int PlayersCount { get; set; }
        public int RoundsCount { get; set; }
        public int CurrentRound { get; set; }
        public Player [] Players;
        public Player ActivePlayer;
        public PhaseName Phase;
        public Queue<Player> RatingQueue;

        public void CreateGame(int playersCount, int roundsCount)
        {
            PlayersCount = playersCount;
            RoundsCount = roundsCount;
            CurrentRound = 0;
            Players = new Player[playersCount];
            for (int i = 0; i < playersCount; i++)
            {
                Players[i] = new Player();
                Players[i].ID = i;
            }
            ActivePlayer = Players[0];
            CurrentRound = 0;
        }

        public int GetActivePlayerID()
        {
            return ActivePlayer.ID;
        }

        public void SwitchPhase(PhaseName phase)
        {
            Phase = phase;
            if (phase == PhaseName.TrackPlaying)
                ActivePlayer = Players[0];
        }

        public bool Rate(int mark)
        {
            ActivePlayer.Score += mark;
            if (RatingQueue.Count>0)
            {
                return true;
            }
            return false;
        }
       
        public void SetRatingQueue()
        {
            RatingQueue = new Queue<Player>();
            foreach (Player player in Players)
            {
                if (player.ID != ActivePlayer.ID)
                {
                    RatingQueue.Enqueue(player);
                }
            }
        }

        public string ScoreNames()
        {
            string result = "";
            foreach (Player player in Players)
            {
                result += player.Name + Environment.NewLine;
            }
            return result;
        }
        public string ScoreValues()
        {
            string result = "";
            foreach (Player player in Players)
            {
                result += player.Score.ToString() + Environment.NewLine;
            }
            return result;
        }

    }
    
}
