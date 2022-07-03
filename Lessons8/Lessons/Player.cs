using System;
using System.Collections.Generic;
using System.Text;


namespace Lessons
{
    class Player
    {
        static Player()
        {
            numbers = new List<int>();
        }
        public Player(string firstName, string lastName, int number, Club club)
        {
            if (CheckNumber(number)) {
                Console.WriteLine("Номер занят, выберите другой номер!");
            }
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            numbers.Add(number);
            Club = club;
        }

        public Player(string firstName, string lastName, Club club)
        {
            int number = GenerateNumber(0);
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            numbers.Add(number);
            Club = club;
        }

        public static List<int> numbers;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string MiddleName { get; private set; }

        public int Number { get; set; }
        public Club Club { get; set; }
        
        public string GetFullName() {
            return string.Join(" ", FirstName, MiddleName, LastName);
        }
        
        private int GenerateNumber(int i) {
            i++;
            int number = numbers[numbers.Count-1] + i;
            if (CheckNumber(number) == false) {
                return number;
            }
            return GenerateNumber(i);
        }

        private bool CheckNumber(int number) {
            if(numbers == null)
                return false;
            if (numbers.Count <= 0) 
                return false;
            return numbers.Contains(number);
        }
        public void PlayerInfo() {
            Console.WriteLine(
                "Firstname: " + FirstName + "\n"
                + "Middlename: " + MiddleName + "\n"
                + "Lastname: " + LastName + "\n"
                + "Number: " + Number + "\n"
                + "Club: " + Club.Name
                );
        }
    }
}
