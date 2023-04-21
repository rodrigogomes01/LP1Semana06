using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private int Rooms;
        private Difficulty Challenge;

        public GameLevel(int Rooms, Difficulty Challenge)
        {
            this.Rooms = Rooms;
            this.Challenge = Challenge;
        }
    }
}