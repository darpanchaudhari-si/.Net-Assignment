namespace static_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accessing Static member 
            Apartment.Address = "No.5 ,Ring Road ,jalgaon";
            Apartment.DisplayApartmentAddress();

            //Accesing instamnce member
            Apartment apartment1 = new Apartment( 101,"sai");
            Apartment apartment2 = new Apartment(102, "ashu");
            Apartment apartment3 = new Apartment(103, "yash");

            apartment1.Display();
            apartment2.Display();
            apartment3.Display();

        }
    }
}