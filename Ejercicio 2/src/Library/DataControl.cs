using System;
using System.Net.Http;
using System.Text;

namespace Library
{
    public static (string validationMessage) isDataValid (PatientData patientData, DocData docData)
    {
        bool isValid = true;
        StringBuilder validationMessage = new StringBuilder("Scheduling appointment...\n");

        if (string.IsNullOrEmpty(patientData.PatientName))
        {
            validationMessage.Append("Patient name is required.\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(patientData.PatientID))
        {
            validationMessage.Append("Patient ID is required.\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(patientData.PatientPhoneNumber))
        {
            validationMessage.Append("Patient phone number is required.\n");
            isValid = false;
        }

        if (docData.DisponibilityList == null)
        {
            validationMessage.Append("Appointment place and time is required.\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(docData.DocName))
        {
            validationMessage.Append("Doctor name is required.\n");
            isValid = false;
        }

        if (string.IsNullOrEmpty(docData.DocSpecialty))
        {
            validationMessage.Append("Doctor specialty is required.\n");
            isValid = false;
        }

        if (isValid)
        {
            validationMessage.Append("Appoinment scheduled");
        }

        return (validationMessage.ToString());
    }
}