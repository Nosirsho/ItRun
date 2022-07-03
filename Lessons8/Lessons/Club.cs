using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class Club
    {
        static Club()
        {
            allClubs = new List<Club>();
        }
        public Club(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public static List<Club> allClubs;

        public string Name { get; private set; }
        public List<Player> Players { get; private set; }

        public void AddPlayer(Player player) {
            Players.Add(player);
        }

        public void ClubInfo() {
            Console.WriteLine("Club: " + Name);
            Console.WriteLine("========================================================");
            foreach(Player player in Players)
            {
                player.PlayerInfo();
            Console.WriteLine("------------------------------------------------------");
            }
        }
    }
}
