namespace _31102024_home_task;
public class Hospital
{
    private List<Appointment> Appointments { get; set; } = new List<Appointment>();

    public void AddAppointment(string patient, string doctor, DateTime startDate)
    {
        int appointmentNo = Appointments.Count + 1;
        var newAppointment = new Appointment(appointmentNo, patient, doctor, startDate, DateTime.MinValue);
        Appointments.Add(newAppointment);
        Console.WriteLine("Appointment added successfully.");
    }
     public void EndAppointment(DateTime endDate, string patient, string doctor)
    {
        var appointment = Appointments.FirstOrDefault(a => a.Patient == patient && a.Doctor == doctor && a.EndDate == DateTime.MinValue);
        if (appointment != null)
        {
            appointment.EndDate = endDate;
            Console.WriteLine("Appointment ended successfully.");
        }
       
    }

    public Appointment GetAppointment(string patient, string doctor)
    {
        return Appointments.FirstOrDefault(a => a.Patient == patient && a.Doctor == doctor);
    }

    public List<Appointment> GetAllAppointments()
    {
        return Appointments;
    }

    public List<Appointment> GetWeeklyAppointments()
    {
        var startOfWeek = DateTime.Now;
        var endOfWeek = startOfWeek.AddDays(7);
        return Appointments.Where(a => a.StartDate >= startOfWeek && a.StartDate < endOfWeek).ToList();
    }

    public List<Appointment> GetTodaysAppointments()
    {
        var today = DateTime.Today;
        return Appointments.Where(a => a.StartDate.Date == today).ToList();
    }

    public List<Appointment> GetAllContinuingAppointments()
    {
        return Appointments.Where(a => a.EndDate == DateTime.MinValue).ToList();
   
}
    }


