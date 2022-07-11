using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public virtual void Walk() {
            Console.WriteLine("Гулять...");
        }
        public virtual void Eat() {
            Console.WriteLine("Кушать...");
        }
        public abstract void Voice();

    }
}
