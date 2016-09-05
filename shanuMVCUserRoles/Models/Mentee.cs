using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shanuMVCUserRoles.Models
{
    public class Mentee
    {
        public int MenteeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Degree { get; set; }
        public int CellPhoneNumber { get; set; }
        public string PassWord { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Points { get; set; }
        public string Province { get; set; }
        public int Rating { get; set; }
        public string LearningInstitution { get; set; }
        //public int YearsOfExperience { get; set; }
        // MentorID not there because of the pair handles that
        public string PreferredJobIndustry { get; set; }
        public string PreferredWorkLocation { get; set; }
        public bool Status { get; set; }
        [AllowHtml]
        public byte[] Image { get; set; }
        public int AdministratorID { get; set; }
        public virtual Administrator Administrator { get; set; }
        public virtual ICollection<Pair> Pair { get; set; }
    }
}