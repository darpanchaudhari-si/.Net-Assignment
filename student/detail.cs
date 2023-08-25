using System;
using System.Reflection.Metadata.Ecma335;
using static System.Console;


namespace student
{
    internal class detail
    {
        const double csharpfee = 2000;
        const double aspfee = 3000;
        
        
        int rollno ;
        string name;
        string course;
        double feespaid;

        public int Rollno
        {
            get { return rollno; }
            set { rollno = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Course
        {
            get { return course; }  
            set { course = value; }
        }
        public double Feespaid
        {
            get { return feespaid; }
            set {
                if (this.course.Equals ("c#"))
                    feespaid = csharpfee;
                if (this.course.Equals("ASP.NET"))
                {
                    feespaid = aspfee;
                }
                
                    
            }
        }
        public detail()
        {

        }
        public detail (int rollno,string number,string course,double feespaid)
        {
            this.rollno = rollno;
            this.name = number;
            this.course = course;
            this.feespaid = feespaid;
        }
        public void Display()
        {
            Console.WriteLine($"the student of{rollno} of {name} is paid{feespaid}then he get{course}");
        }

        
        

    
    }
}




    

