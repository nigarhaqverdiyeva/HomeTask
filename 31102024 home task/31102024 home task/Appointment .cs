﻿namespace _31102024_home_task;
public class Appointment
{
    public int No { get; set; }
    public string Patient { get; set; }
    public string Doctor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Appointment(int no,string patient, string doctor, DateTime startDate, DateTime endDate)
    {
        No= no;
        Patient = patient;
        Doctor = doctor;
        StartDate = startDate;
        EndDate = endDate;
    }

}
