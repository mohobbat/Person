using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class PersonList
    {
        public string firstName;
        public string lastName;
        public string middleName;


        public string GetfullName()
        {
            return firstName + " " + middleName+ " " + lastName;
        }

        public string GetReversName()
        {
            string revrsName=" ";
            string fullname=GetfullName();

            for (int i = fullname.Length - 1; i >= 0; i--)
            {
                revrsName += fullname[i];
            }
            return revrsName;
        }


    }
}
