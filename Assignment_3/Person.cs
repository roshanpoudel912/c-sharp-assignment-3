using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Person : BaseClass
    {
        public string FirstName {get;set;}
        public string LastName { get;set;}
        public Person(string firstName="", string lastName="")
        {
            FirstName= firstName;
            LastName= lastName;

        }

        public override Boolean IsValidated()
        {
           FirstName =  FirstName ?? "";
           LastName = LastName ?? "";

            if((FirstName.Length > 0) && (LastName.Length > 0)){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
