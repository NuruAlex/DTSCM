using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataBase.Tables.Staffs
{
    public class Director: IStaff
    {
        public int Id { get; set; }
        public string Initials { get; set; }
        public string StaffPassword { get; set; }
        public string Post { get; set; }
    }
}
