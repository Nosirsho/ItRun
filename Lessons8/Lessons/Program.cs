using System;
using System.Collections.Generic;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Club liverpool = new Club("Liverpool");
            Club barselona = new Club("Barselona");

            Player player1 = new Player("Lionel", "Messi", 10, barselona);
            Player player3 = new Player("Mickhael", "Owen", 11, liverpool);
            Player player2 = new Player("Stiven", "Gerrad", 4, liverpool);
            Player player4 = new Player("David", "Beckham", 7, liverpool);
            Player player5 = new Player("Sadio", "Mane", 9, liverpool);
            Player player6 = new Player("Mark", "Terstegen",  barselona);
            
            barselona.AddPlayer(player1);
            barselona.AddPlayer(player6);
            liverpool.AddPlayer(player2);
            liverpool.AddPlayer(player3);
            liverpool.AddPlayer(player4);
            liverpool.AddPlayer(player5);

            Console.WriteLine("Информация об игроке");
            player1.PlayerInfo();
            Console.WriteLine("Информация о клубе");
            barselona.ClubInfo();
            Console.WriteLine("Информация о клубе");
            liverpool.ClubInfo();
        }
    }
}
