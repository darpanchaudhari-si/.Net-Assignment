using DelegateDemo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo { 
  internal class calculator
    {
        public string concate(string x, string y) 
        {
            return x + "" + y;
        }
        public int Add (int x, int y)
        {
            return x + y;
        }
        public int AddDouble(double x, double y)
        {
            return x + y;
        }
        public int Sub (int x, int y)
        {
            return x - y;
        }
        public int Mul (int x, int y)
        {
            return (x * y) + y;
        }
        public int Div (int x, int y)
        {
             return x / y;
        }

        

        
    }
}
