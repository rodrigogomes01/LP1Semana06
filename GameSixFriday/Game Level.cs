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

            public void SetFoeInRoom(int room, Foe foe)
        {
            Foes[room] = foe;
        }
    }
}