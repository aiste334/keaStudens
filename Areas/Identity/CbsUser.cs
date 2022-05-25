using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Areas.Identity;

public class CbsUser : IdentityUser
{
    [PersonalData]
    public string  FirstName { get; set; }
    [PersonalData]
    public string LastName { get; set; }
}