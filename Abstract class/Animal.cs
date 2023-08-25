using Abstract_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    abstract internal class Animal
    {
        public Animal(string name)

        {
            Name = name;

        }
        public string Name { get; set; }
        abstract public string Speak();

        public void Display()
        {
            Console.WriteLine($"{Name} says {Speak()}");

        }

    }

}
class Dog : Animal
{
    public Dog(String name) : base(name)
    {
    }
    public override string Speak()
    {
        return "Bow Bow";
    }
}

class cat : Animal
{
    public cat (string name) : base(name)
    {
    }
    public override string Speak()
    {
        return "meow meow";
    }
}
class cow : Animal
{
    public cow (string name) : base(name)
    {
    }
    public override string Speak()
    {
        return "muhoooo";
    }
}


