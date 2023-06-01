using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
        public partial class PartialCustomer
        {
        public string getfullname()
        {
            return _firstName + " " + _lastName;
            //Console.WriteLine(_firstName);
            //return _firstName;
        }
        
        }
    }


