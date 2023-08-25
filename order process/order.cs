using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace order_process
{
    internal class order
    {
        public int num{ get; set; }

        public string name{ get; set; }

        public int quantity { get; set; }
         
        public int totalprice { get; set; }

        public order (int num,string name,int quantity)
        {
            this.num = num;
            this.name = name;
            this.quantity = quantity;

        }
        public override string ToString()
        {
            return $"num :{num}, name :{name}, quantity :{quantity}";
        }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                order other = obj as order;
                if(this.name == other.name && this.quantity.Equals(other.quantity))
                {
                    return true;
                }
                return false;

            }
            Public override int GetHashCode()
            {
                return HashCode.Combine(name, quantity);
        }
            }



    }
}
