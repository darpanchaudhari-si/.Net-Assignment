using System;
using System.ComponentModel.DataAnnotations;
using static System.Console;

namespace carproject
{
    internal class Car // this is class
    {
        string carName;// it is variable
        string color;
        int speed;

        public string CarName //it is property
        {
            get { return carName; }
            set { carName = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { 
                if (value >=5)
                { speed = value; }
                else
                {
                    speed = 5;
                }
            }
        }

            public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Car (string name , string color) // constructor
        {
            this.carName = name;
            this.color = color;
        }

        public Car()
        {
            carName = "New car";
            color = "Black";
            speed = 30;
        }
        public Car(string carName, string color, int speed)
        {
            this.carName = carName;
            this.color = color;
            this.speed = speed;
        }

        public void SpeedUp(int delta)
        {
            speed = delta;
        }
        public void Display()
        {
            WriteLine($"{carName} is {color} and running at a speed of {speed} km/hr");
        }
    }
}
