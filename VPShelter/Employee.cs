using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
   public abstract class Employee
    {
       
        public int EmployeeID { get; set; }

        //methods
        public abstract void ClockIN(double time);
        public abstract void ShowID(string name,int id);

        
    }
}
