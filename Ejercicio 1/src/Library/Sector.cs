using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public List<Shelve> ShelvesList { get ; set; }

        public string LibrarySector { get ; set; }

        public string SectorLetter;
        public Sector(string sectorLetter)
        {
            this.SectorLetter = sectorLetter;
            this.ShelvesList = new List<Shelve>();
        }

        public void AddShelve(Shelve shelve)
        {
            ShelvesList.Add(shelve);
        }

    }
}
