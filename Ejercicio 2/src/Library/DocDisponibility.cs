using System;

namespace Library
{
    public class DocDisponibility
    {
        public DateTime Date {get; set; }
        public string AppoinmentPlace {get; set; }

        public DocDisponibility (DateTime date, string appoinmentPlace)
        {
            this.Date = date;
            this.AppoinmentPlace = appoinmentPlace;
        }
    }
}