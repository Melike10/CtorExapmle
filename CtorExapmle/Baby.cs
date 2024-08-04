using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorExapmle
{
    internal class Baby
    {
        // fields
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

        // default constructure
        public Baby()
        {

        }
        // constructure with parameters
        public Baby(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            Console.WriteLine("Ingaaa");
            _dateOfBirth = DateTime.Now;
        }

        // properties
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        public void IntroduceBaby()
        {
            Console.WriteLine("Bebeğin bilgileri --> "+FirstName+" "+LastName+ " "+DateOfBirth);

        }

    }
}
