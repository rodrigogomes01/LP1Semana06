using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private Difficulty challenge;
        private int Num_Foes;
        Foe[] Room_Foes;

        public GameLevel(int rooms, Difficulty challenge)
        {
            this.challenge = challenge;
            Room_Foes = new Foe[rooms];
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            Room_Foes[room - 1] = foe;
        }

        public Difficulty GetDifficulty()
        {
            return challenge;
        }

        public int GetNumRooms()
        {
            return Room_Foes.Length;
        }

        public int GetNumFoes()
        {
            int Num_Foes = 0;
            for (int i = 0; i < Room_Foes.Length; i++)
            {
                if (Room_Foes[i] != null) Num_Foes++;
            }
            return Num_Foes;
        }

        public void PrintFoes()
        {
            for (int i = 0; i < Room_Foes.Length; i++)
            {
                if (Room_Foes[i] != null)
                {
                    Console.WriteLine($"Room {i + 1}: {Room_Foes[i].GetName()}");
                }
            }
        }
    }
}