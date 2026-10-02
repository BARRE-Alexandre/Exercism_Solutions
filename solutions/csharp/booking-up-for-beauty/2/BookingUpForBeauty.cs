static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime date = DateTime.Parse(appointmentDateDescription);
        return date;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (DateTime.Now > appointmentDate) {
            return true;
        }
        else {
            return false;
        }
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if(appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) {
            return true;
        }
        else {
            return false;
        }
    }

    public static string Description(DateTime appointmentDate) =>
        "You have an appointment on " + appointmentDate.ToString("M/d/yyyy h:mm:ss tt") + ".";

    public static DateTime AnniversaryDate() =>
        new DateTime(DateTime.Now.Year,09,15);
}
