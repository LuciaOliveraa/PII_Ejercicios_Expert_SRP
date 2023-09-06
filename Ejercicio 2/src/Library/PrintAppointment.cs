using System;

namespace Library
{
    public class PrintAppointment
    {
        public PatientData PatientInfo {get; }
        public DocData Doctor {get; }
        
        public (string message) PrintConsole (PatientData patient, DocData doc)
        {
            Console.WriteLine(isDataValid(patient, doc));
        }
    }
}