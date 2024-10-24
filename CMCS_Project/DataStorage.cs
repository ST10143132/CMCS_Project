using System.Collections.Generic;

namespace CMCS_Project
{
    public static class DataStorage
    {
        public static List<DataUser> Users = new List<DataUser>();
        public static List<ClaimData> Claims = new List<ClaimData>();

        public static List<DataUser> GetLecturersWithClaims()
        {
            List<DataUser> lecturersWithClaims = new List<DataUser>();
            foreach (var claim in Claims)
            {
                var lecturer = Users.Find(u => u.Username == claim.LecturerUsername);
                if (lecturer != null && !lecturersWithClaims.Contains(lecturer))
                {
                    lecturersWithClaims.Add(lecturer);
                }
            }
            return lecturersWithClaims;
        }
    }

    public class DataUser
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class ClaimData
    {
        public string ClaimID { get; set; }
        public string LecturerUsername { get; set; }
        public decimal HoursWorked { get; set; }
        public string Status { get; set; }
    }
}
