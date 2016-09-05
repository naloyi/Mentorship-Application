using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shanuMVCUserRoles.Models
{
    public class Personal_Meeting
    {
        public int PersonalMeetingID { get; set; }
        public bool Mentee_Attendance_Status{ get; set; }
        public bool Mentor_Attendance_Status { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Meeting_Location { get; set; }
        public int Mentee_Rating { get; set; }
        public int Mentor_Rating { get; set; }
        public string Interaction_Type { get; set; }
        public int PairID { get; set; }
        public virtual Pair Pair { get; set; }
    }
}