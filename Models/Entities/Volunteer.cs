using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class Volunteer
{

public int Id { get; set; }

public string Name { get; set; }

public string LastName { get; set; }

public string Email { get; set; }

public int PhoneNumber { get; set; }

public VolunteerStatus Status { get; set; }

public List<Event> Events { get; set; }

public List<Task> Tasks {get; set; }
}