namespace CollectionDemo
{
    internal class Employee
    {
        public int id { get; set; }
        public string name { get; set; }

        public double salary { get; set; }

        public string department { get; set; }

        public override string ToString()
        {
            return $"Id:{id}   Name:{name}   Salary:{salary}   Department:{department}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                Employee other = obj as Employee;
                if (this.id == other.id)
                {
                    return true;

                }

            }
            return false;

        }
        public override int GetHashCode()
        {
            return id;
        }
    }
}