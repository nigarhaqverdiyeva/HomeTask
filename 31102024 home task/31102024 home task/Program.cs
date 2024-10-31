namespace _31102024_home_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hospital = new Hospital();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Appointment yarat");
                Console.WriteLine("2. Appointment-i bitir");
                Console.WriteLine("3. Bütün appointment-lərə bax");
                Console.WriteLine("4. Bu həftəki appointment-lərə bax");
                Console.WriteLine("5. Bugünki appointment-lərə bax");
                Console.WriteLine("6. Bitməmiş appointmentlərə bax");
                Console.WriteLine("7. Menudan çıx");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Patient Name: ");
                        string patient = Console.ReadLine();
                        Console.Write("Doctor Name: ");
                        string doctor = Console.ReadLine();
                        Console.Write("Start Date (yyyy-mm-dd hh:mm): ");
                        DateTime startDate = DateTime.Parse(Console.ReadLine());
                        hospital.AddAppointment(patient, doctor, startDate);
                        break;
                    case "2":
                        Console.Write("End Date (yyyy-mm-dd hh:mm): ");
                        DateTime endDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Patient Name: ");
                        string endPatient = Console.ReadLine();
                        Console.Write("Doctor Name: ");
                        string endDoctor = Console.ReadLine();
                        hospital.EndAppointment(endDate, endPatient, endDoctor);
                        break;
                    case "3":
                        foreach (var appointment in hospital.GetAllAppointments())
                        {
                            Console.WriteLine($"{appointment.Patient} with {appointment.Doctor} from {appointment.StartDate} to {appointment.EndDate}");
                        }
                        break;
                    case "4":
                        foreach (var appointment in hospital.GetWeeklyAppointments())
                        {
                            Console.WriteLine($"{appointment.Patient} with {appointment.Doctor} on {appointment.StartDate}");
                        }
                        break;
                    case "5":
                        foreach (var appointment in hospital.GetTodaysAppointments())
                        {
                            Console.WriteLine($"{appointment.Patient} with {appointment.Doctor} on {appointment.StartDate}");
                        }
                        break;
                    case "6":
                        foreach (var appointment in hospital.GetAllContinuingAppointments())
                        {
                            Console.WriteLine($"{appointment.Patient} with {appointment.Doctor} ongoing since {appointment.StartDate}");
                        }
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
 }