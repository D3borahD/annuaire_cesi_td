//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    public class EmployeeFormated
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Landline { get; set; } = null!;

        public string Mobile { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int SiteId { get; set; }
        public string Site { get; set; }

        public int DepartmentId { get; set; }
        public string Department { get; set; }

    }
}
