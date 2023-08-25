namespace Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Laptop l1 = new Laptop();
            l1.ExecuteProgram();
            l1.DecreaseVolume(2);
            l1.IncreaseVolume(2);
            l1.PlayMusic("some song");
            l1.ClickImage();
                
            //Animal a1 = new Dog("Dog");
            //Animal a2 = new cat("cat");
            //Animal a3 = new cow("Cow");
            //a1.Display();
            //a2.Display();
            //a3.Display();

            Console.ReadLine();

        }
    }
}