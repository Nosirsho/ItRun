using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    abstract class Canine : Animal
    {
        public void Swim() {
            Console.WriteLine("Плавать");
        }
    }
}
