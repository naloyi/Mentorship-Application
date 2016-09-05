using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shanuMVCUserRoles.Models
{
    public class Mentor
    {
        public int MentorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Archievement { get; set; }
        public int Rating { get; set; }
        public string JobIndustry { get; set; }
        public int YearsOfExperience { get; set; }
        public string Email { get; set; }
        public int CellPhoneNumber { get; set; }
        public string PassWord { get; set; }
        public string Company { get; set; }
        public bool Status { get; set; }
        public int NumberOfMentees { get; set; }
        public int Points { get; set; }
        public int AdministratorID { get; set; }
        public virtual Administrator Administrator { get; set; }
        public virtual ICollection<Pair> Pair { get; set; }
    }
}