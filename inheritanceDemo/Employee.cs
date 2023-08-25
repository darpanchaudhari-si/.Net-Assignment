using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceDemo
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Employee(int id , string name)
        {
            Id = id;
            Name = name;

        }
        public override string ToString()
        {
            return $"Id :{Id} , Name :{Name}";
        }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Employee other = obj as Employee;
                if (this.Id == other.Id && this.Name.Equals(other.Name))
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }


    }
}
