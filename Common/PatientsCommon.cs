using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PatientsCommon
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Nullable<int> HouseNumber { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<int> MobilePhone { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
    }
}
