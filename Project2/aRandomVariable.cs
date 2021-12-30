using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Cop4365
{
    /// <summary>
    /// intermediate class inherit from random class 
    /// Why this intermediate class(aRandomVariable)is a good approach: 
    /// Since we can create a static random variable from this. 
    /// Which allows for reusibility of a variable not have to create mutiples ones for different objects
    /// 
    /// This practice using intermediate class calls inheritance. All the derived class can access all function of base class.
    /// which promotes reusability, less development, base code could also be tested, helps to reduce code 
    /// </summary>
    class aRandomVariable : Random
    {
        /// <summary>
        /// random variable for class 
        /// </summary>
        protected static Random rand;

    }
}
