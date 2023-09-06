using System;

namespace Library
{
    public class PatientData
    {
        public string PatientName {get; set;}
        public string PatientID {get; set;}
        public string PatientPhoneNumber {get; set;}
        public string PatientAge {get; set; }

        public PatientData(string name, string id, string phone_number, string age)
        {
            this.PatientName = name;
            this.PatientID = id;
            this.PatientPhoneNumber = phone_number;
            this.PatientAge = age;
        }
    }
}