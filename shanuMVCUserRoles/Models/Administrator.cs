using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shanuMVCUserRoles.Models
{
    public class Administrator
    {
        public int AdministratorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int CellPhoneNumber { get; set; }
        //public string PassWord { get; set; }
        public bool Status { get; set; }
        //public virtual ICollection<C> Courses { get; set; }
        public virtual ICollection<Mentor> Mentor { get; set; }
        public virtual ICollection<Mentee> Mentee { get; set; }
    }
}