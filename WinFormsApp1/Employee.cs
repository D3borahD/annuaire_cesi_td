using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Employee
    {
        public int id { get; set; }

        public String firstname { get; set; }
        public String lastname { get; set; }

        public String landline { get; set; }

        public String mobile { get; set; }

        public String email { get; set; }

        public Site site { get; set; }

        public Department department { get; set; }
    }
}
