using shanuMVCUserRoles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shanuMVCUserRoles.DataAccessLayer
{
    public class MentorshipInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Mentorship>
    {


        protected override void Seed(Mentorship context)
        {

            var administrators = new List<Administrator>
            {

              new Administrator{AdministratorID=1,Name="Ngudu",Surname= "Sibanda",Email="dsff@gmail.com",CellPhoneNumber=079865342,Status=true},
            };
            administrators.ForEach(s => context.Administrator.Add(s));
            context.SaveChanges();

            var mentees = new List<Mentee>
            {

            new Mentee{MenteeID=1,FirstName="Carson",LastName="Alexander",DateOfBirth=DateTime.Parse("1995-09-01"),Email="zeraa@gmail.com",Degree="Bsc Computer Science",CellPhoneNumber= 0797203456,PassWord="nah",Points=21, Province="Mpumalanga",Rating=11,LearningInstitution="Witswatersrand",PreferredJobIndustry="ICT", PreferredWorkLocation="Gauteng",AdministratorID=1, Status=true},
            new Mentee{FirstName="Meredith",LastName="Alonso",DateOfBirth=DateTime.Parse("1993-08-01"),Email="zeoraa@gmail.com",Degree="Bsc Computer Science",CellPhoneNumber= 0797203456,PassWord="nah",Points=21, Province="Mpumalanga",Rating=11,LearningInstitution="Witswatersrand",PreferredJobIndustry="ICT", PreferredWorkLocation="Gauteng",AdministratorID=1, Status=true},
            new Mentee{FirstName="Arturo",LastName="Anand",DateOfBirth=DateTime.Parse("1988-07-01"),Email="zeraa@gmail.com",Degree="Bsc Computer Science",CellPhoneNumber= 0797203456,PassWord="nah",Points=21, Province="Mpumalanga",Rating=11,LearningInstitution="Witswatersrand",PreferredJobIndustry="ICT", PreferredWorkLocation="Gauteng",AdministratorID=1, Status=true},
            new Mentee{FirstName="Gytis",LastName="Barzdukas",DateOfBirth=DateTime.Parse("1997-05-01"),Email="zeraa@gmail.com",Degree="Bsc Computer Science",CellPhoneNumber= 0797203456,PassWord="nah",Points=21, Province="Mpumalanga",Rating=11,LearningInstitution="Witswatersrand",PreferredJobIndustry="ICT", PreferredWorkLocation="Gauteng",AdministratorID=1, Status=true},
            new Mentee{FirstName="Yan",LastName="Li",DateOfBirth=DateTime.Parse("1994-03-01"),Email="zeraa@gmail.com",Degree="Bsc Computer Science",CellPhoneNumber= 0797203456,PassWord="nah",Points=21, Province="Mpumalanga",Rating=11,LearningInstitution="Witswatersrand",PreferredJobIndustry="ICT", PreferredWorkLocation="Gauteng",AdministratorID=1, Status=true},

            };
            mentees.ForEach(s => context.Mentee.Add(s));
            context.SaveChanges();




            var mentors = new List<Mentor>


             {
                 new Mentor{MentorID=1,FirstName="Calvin",LastName="Mayer",DateOfBirth=DateTime.Parse("1995-09-01"),Email="zeraa@gmail.com",Archievement="Programmer of the year",CellPhoneNumber= 0797203456,PassWord="dengo",Points=21, JobIndustry="ICT",Rating=11,Company="Entelect",YearsOfExperience= 3,NumberOfMentees=3,AdministratorID=1, Status=true},

             };
            mentors.ForEach(s => context.Mentor.Add(s));
            context.SaveChanges();

            var pairs = new List<Pair>
            {


               new Pair{PairID=1,MentorID =1, MenteeID = 1,Status=true,StartDate=DateTime.Parse("2004-09-01"), EndDate=DateTime.Parse("2009-09-01")},
            };
            pairs.ForEach(s => context.Pair.Add(s));
            context.SaveChanges();
        }


    }
}