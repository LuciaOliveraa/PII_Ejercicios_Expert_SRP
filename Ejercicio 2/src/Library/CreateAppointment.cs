using System;

namespace Library
{
    public class CreateAppointment
    {
        public PatientData PatientInfo {get; }
        public DocData Doctor {get; }
        
        public CreateAppointment (PatientData patient, DocData doc)
        {
            if (isDataValid(patient, doc).Contains("Appoinment scheduled"))
            {
                this.PatientInfo = patient;
                this.Doctor = doc;
            }
        }
    }
}