using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shanuMVCUserRoles.Models
{
    public class Pair
    {
        public int PairID { get; set; }
        // foreing keys
        public int MentorID { get; set; }
        public int MenteeID { get; set; }
        //public int GroupID { get; set; }
        //
        public bool Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // Navigation property
        public virtual Mentor Mentor { get; set; }
        public virtual Mentee Mentee { get; set; }

    }
}