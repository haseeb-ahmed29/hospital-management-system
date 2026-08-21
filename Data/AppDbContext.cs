using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients => Set<Patient>();
 public DbSet<Doctor> Doctors => Set<Doctor>();
 public DbSet<Appointment> Appointments => Set<Appointment>();
}
