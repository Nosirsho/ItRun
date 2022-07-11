using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    abstract class Feline : Animal
    {
        public void Climb() {
            Console.WriteLine("Лазать по деревям");
        }
    }
}
