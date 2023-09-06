using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientData patient1 = new PatientData ("nombre", "ci", "celular", "edad");
            DocDisponibility disponibilityDoc1 = new DocDisponibility (date, "lugar");
            DocData doc1 = new DocData ("nombre doc", "especialidad");
            DisponibilityList.AddDate(disponibilityDoc1);
            
            CreateAppointment appointment1 = new CreateAppointment (patient1, doc1);
            PrintConsole (patient1, doc1);
            
            /*
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);*/
        }
    }
}


