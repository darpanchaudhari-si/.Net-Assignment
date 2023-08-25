using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            int result = 0;
            if (x != null && y != null)
            {
                result = 0;
            }
            if (x is null)
            {
                result = -1;
            }
            if (y is null)
            {
                result = 1;
            }
            if (x.salary == y.salary)
            {
                result = 0;
            }
            if (x.salary > y.salary)
            {
                result = 1;
            }
            if (x.salary < y.salary)
            {
                result = -1;
            }
            return result;
        }
    }
    
    
}
