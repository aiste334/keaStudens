using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace cbsStudents.Models.Entities;

public class Event
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Please fill out title")]
    [MinLength (5)]
    public string Title { get; set; }

    [MinLength(10, ErrorMessage = "Minimum 10 characters")]
    public string Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime Date { get; set; }

    public int VolunteerId { get; set; }
    public Volunteer Volunteer { get; set; }
}