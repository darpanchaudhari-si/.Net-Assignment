using System;
namespace _4.Student_Grading_System_with_Exception_Handling
{
    internal class Program
    {
       



class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public double CalculateAverageGrade()
        {
            double total = 0;
            foreach (int grade in Grades)
            {
                total += grade;
            }
            return total / Grades.Length;
        }
    }

    class Detail
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of grades: ");
            int numGrades = int.Parse(Console.ReadLine());

            Student student = new Student
            {
                Name = name,
                Grades = new int[numGrades]
            };

            for (int i = 0; i < numGrades; i++)
            {
                bool validInput = false;
                while (!validInput)
                {
                    try
                    {
                        Console.Write($"Enter grade {i + 1}: ");
                        int grade = int.Parse(Console.ReadLine());

                        if (grade < 0 || grade > 100)
                        {
                            throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
                        }

                        student.Grades[i] = grade;
                        validInput = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric grade.");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            double averageGrade = student.CalculateAverageGrade();
            Console.WriteLine($"Average Grade for {student.Name}: {averageGrade:F2}");
        }
    }

}
}