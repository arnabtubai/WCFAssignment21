using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAssign
{
   
    public class Calculator : ICalculator
    {

        public int Add(int x, int y)
        {
            return x + y;
        }

       

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
}
