using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_demo
{
    internal class Apartment
    {
        public int ApartmentNo { get; set; }
        public  string OwnerName  { get; set; }

        public static int NoOfHousesBought { get; set; }
        public static string Address { get; set; }
        public Apartment(int  apartmemntNo, string ownerName)
        {
            ApartmentNo = apartmemntNo;
            OwnerName = ownerName;
            ++NoOfHousesBought;// add the count wheen house bought

        } 
        public void Display()
        {
            Console.WriteLine($"Apartmant No : {ApartmentNo}, Owner Name :{OwnerName}");
        }
        public static void DisplayApartmentAddress()
        {
            Console.WriteLine($"Apartment Address : {Address}");
        }
        public static void DisplayTotalNumberOfHouseBought() 
        {
            Console.WriteLine($"House Bought : {NoOfHousesBought}");
        }


    }
}
