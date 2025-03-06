namespace BookingAppointment
{

    class Program
    {
        static void Main()
        {
            List<string> appointments = new List<string>();
            string input;

            do
            {
                Console.WriteLine("Welcome to Lash and Nails Booking System!");
                Console.WriteLine("(1). Add Appointment!");
                Console.WriteLine("(2). View Appoinment");
                Console.WriteLine("(3). Exit");
                Console.WriteLine("Please select an option:");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Birthday: ");
                        string birthday = Console.ReadLine();

                        Console.Write("Enter Appointment Date: ");
                        string date = Console.ReadLine();

                        string appointment = $"Name: {name}, Birthday: {birthday}, Date: {date}";
                        appointments.Add(appointment);
                        Console.WriteLine("Appointment Added!");
                        break;
                    case "2":
                        Console.WriteLine("Your Appointments:");
                        foreach (var appt in appointments)
                        {
                            Console.WriteLine("- " + appt);
                        }
                        break;
                    case "3":
                    
                        Console.WriteLine("Thankyou for Booking with us, Have a great day!");
                        break;

                    default:
                        Console.WriteLine("INVALID OPTION");
                        break;







                }

            } while (input != "3");
        }
    }
}