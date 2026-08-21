using System.ComponentModel.DataAnnotations;
namespace HospitalManagementSystem.Models;
public class Appointment
{
 public int Id {get;set;}
 [Required, StringLength(140)] public string PatientName {get;set;} = string.Empty;
 [Required, StringLength(120)] public string AppointmentDate {get;set;} = string.Empty;
 public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
}
