using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class Patients_tbl
    {

        public string FullName { get => FirstName.TrimEnd() + " " + LastName.TrimEnd(); }
    }
}
