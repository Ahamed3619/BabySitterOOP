using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter
{
    class Employee:Phone
    {
       
        public String address  { get; set; }
        public EmergencyContact myObject1 = new EmergencyContact();
        public List<Child> AllChild = new List<Child>();    
    }

}
