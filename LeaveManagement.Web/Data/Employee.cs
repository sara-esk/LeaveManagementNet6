using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    public class Employee : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfJoined { get; set; }

    }
}
}
