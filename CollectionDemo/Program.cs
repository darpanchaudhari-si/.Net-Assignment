namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeUtility emput = new EmployeeUtility();
            UserInterface ui = new UserInterface();

            Console.WriteLine(" 1:Add Employee \n " +
                            " 2:Search By Name \n " +
                            " 3:Search By Id \n  " +
                            "4:Search All Employees Of Department \n  " +
                            "5:Display Employees \n ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        string name = ui.getName();
                        int id = ui.getId();
                        string department = ui.getDepartment();
                        double salary = ui.getSalary();
                        Employee emp = emput.CreateEmployee(id, name, department, salary);
                        emput.AddEmployee(emp);
                        bool isAdded = emput.AddEmployee(emp);
                        if (isAdded) { Console.WriteLine("Employee Added Succesfully"); }
                        else
                        {
                            Console.WriteLine("Employee not Added");
                        }
                        emput.DisplayEmployees();

                        break;
                    }
                case 2:
                    {
                        string name = ui.getName();
                        emput.SearchByName(name);
                        break;

                    }
                case 3:
                    {
                        int id = ui.getId();
                        emput.SearchById(id);
                        break;
                    }

                case 4:
                    {
                        string department = ui.getDepartment();
                        emput.SearchByDepartment(department);
                        break;
                    }
                case 5:
                    {
                        emput.DisplayEmployees();
                        break;
                    }
                case 6:
                    {
                        emput.sortEmployeeBySalary();
                        break;
                    }
            }
            //Find Employee by Name ,Id, Same departement

            /* ArrayList list = new ArrayList();
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add("Sagar");
             list.Add("Anas");
             list.Add(new Array[4]);
             list.Add(new Hero());

             foreach (object item in list)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("\n");

             List<int> list1 = new List<int>();
             list1.Add(1);
             list1.Add(2);
             list1.Add(3);

             foreach(object item in list1)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("\n");

             List<double> list2 = new List<double>();
             list2.Add(1.90);
             list2.Add(20.45);
             list2.Add(90.21);

             foreach(object item in list2)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("\n");

             List<string> list3 = new List<string>()
             { "Sagar","Anas","Jay","Anchal","Jay","Jay"};

             foreach(string item in list3)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine($"Count:{list3.Count}");
             Console.WriteLine($"Capacity:{list3.Capacity}");
             //Console.WriteLine(list3.Remove(list3[2]));
             Console.WriteLine(list3.Contains("Jay"));

             string name = Console.ReadLine();
             Console.WriteLine(" Predicate Methods\n");
             var result = list3.Find(ele => ele.Equals(name));

             list3.RemoveAll(ele => ele.Equals("Jay"));
             foreach (string item in list3)
             {
                 Console.WriteLine(item);*/
        }
    }
}


//List<int> list = new List<int>();
//list.Add(11);
//list.Add(12);
//list.Add(13);


//ArrayList list = new ArrayList();   // non generic type of collection example
//list.Add("darpan");
//list.Add("sai");
//list.Add(8.98);
//list.Add(new Employee());
//list.Add(new int[3]);

//foreach(int item in list)
//{
//    Console.WriteLine(item);
//}

// Collection of string
//List<string> fruits = new List <string>();
//fruits.Add("Apple");
//fruits.Add("Mango");
//fruits.Add("banana");
//fruits.Add("orange");

//foreach (string item in fruits)
//{
//    Console.WriteLine(item);
//}

//Collection of double :-
//List<Double> doubles = new List<Double>();
//doubles.Add(1.0);
//doubles.Add(11.09);

//foreach (double item in doubles)
//{
//    Console.WriteLine(item);
//}
//var num = 7.8;
//num = 9.0;

// collection of strings;
//List<String> fruits = new List<String>() { "apple", "orange", "lichi", "mango" };

//Console.WriteLine("Enter the fruit name to search");
//string name = Console.ReadLine();
//var result = fruits.Find(x => x.Equals(name));
//Console.WriteLine("Result is" + result);

//fruits.RemoveAll(elem => elem.Equals("apple"));
//foreach(string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}

//Console.WriteLine("lichi is at position" + fruits.IndexOf("lichi"));
//Console.WriteLine("Is apple Is removed " + fruits.Remove("Apple"));
//Console.WriteLine("----------------------------------------");
//Console.WriteLine("apple found in fruits" + fruits.Contains("apple"));
//Console.WriteLine("lichi is at position" + fruits.IndexOf("lichi"));

//Console.WriteLine("Capacity :" + fruits.Capacity); // capacity doubles everytime after adding
//Console.WriteLine("count :" + fruits.Count);

//Console.ReadLine();










