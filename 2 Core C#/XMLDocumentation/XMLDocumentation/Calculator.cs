using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLDocumentation
{
    ///<summary>
    /// XMLDocumentation.Calculator class.
    /// Provides a method to add 2 doubles.
    ///</summary>
    public static class Calculator
    {
        ///<summary>
        /// The Add method allows us to add 2 doubles.
        ///</summary>
        ///<returns>Result of the addition (double).</returns>
        ///<param name="double1">1st number to add.</param>
        ///<param name="double2">2nd number to add.</param>
        
        public static double Add(double double1, double double2) => double1 + double2;
    }
}
