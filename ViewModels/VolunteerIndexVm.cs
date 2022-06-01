namespace cbsStudents.Models.Entities;

public class VolunteerIndexVm
{
    public IEnumerable<Volunteer> Volunteers { get; set; }
    public string SearchString { get; set; }
}