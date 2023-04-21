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
            Room_Foes = new Foe[Rooms];
        }

            public void SetFoeInRoom(int room, Foe foe)
        {
            FoesInRoom[room - 1] = foe;
        }

        public Difficulty GetDifficulty()
        {
            return Challenge;
        }

        public int GetRooms()
        {
            return Rooms;
        }

        public int GetFoes()
        {
            int Num_Foes = 0;
            for (int i = 0; i < Room_Foes.Length; i++)
            {
                if (Room_Foes[i] != null) Num_Foes++;
            }
            return Num_Foes;
        }
    }
}