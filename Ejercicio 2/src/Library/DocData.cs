using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class DocData
    {
        public string DocName {get; set;}
        public string DocSpecialty {get; set;}
        public List<DocDisponibility> DisponibilityList {get; set; }

        public DocData (string name, string specialty)
        {
            this.DocName = name;
            this.DocSpecialty = specialty;
            this.DisponibilityList = new List<DocDisponibility>();
        }

        public void AddDate (DocDisponibility disponibility)
        {
            DisponibilityList.Add(disponibility);
        }
    }
}