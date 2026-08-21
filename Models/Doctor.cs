using System.ComponentModel.DataAnnotations;
namespace HospitalManagementSystem.Models;
public class Doctor
{
 public int Id {get;set;}
 [Required, StringLength(140)] public string DoctorName {get;set;} = string.Empty;
 [Required, StringLength(120)] public string Specialization {get;set;} = string.Empty;
 public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
}
