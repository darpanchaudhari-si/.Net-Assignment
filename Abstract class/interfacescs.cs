using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public interface Icamera
    {
        void ClickImage();
    }
    public interface ImusicSystem
    {
        void PlayMusic(string song);
        void IncreaseVolume(int delta);

        void DecreaseVolume(int delta);
    }
    class Mobile : Icamera
    {
        public void ClickImage()
        {
            Console.WriteLine("Image Clicked");
        }
    }
    class Computer
    {
        public void ExecuteProgram()
        {
            Console.WriteLine("Execting program");
        }

    }
    class Laptop : Computer, ImusicSystem, Icamera
    {
        public void ClickImage()
        {
            Console.WriteLine("Image Clicked");
        }
        public void DecreaseVolume(int delta)
        {
            Console.WriteLine("Volume decreased");
        }
        public void IncreaseVolume(int delta)
        {
            Console.WriteLine("Volume Increase");
        }
        public void PlayMusic(string song)
        {
            Console.WriteLine("Playing Music" + song);
        }



        interface IGame
        {
            void PlayGame1();
        }

        interface IGame2 : IGame
        {
            public void PlayGame1()
            {
                throw new NotImplementedException();
            }
            public void PlayGame2()
            {
                throw new NotImplementedException();
            }
        }
     }  
    

}
 
