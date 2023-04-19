using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Számlavezetés
{
    public class Tetel
    {

        int id;
        DateTime datum;
        int osszeg;
        string partnerNeve;
        string foKategoria;
        string alKategoria;


        public Tetel (string csvSor)
        {
            string[] mezok = csvSor.Split(',');

            this.id = int.Parse(mezok[0]);
            this.datum = Convert.ToDateTime(mezok[1]);
            this.osszeg = int.Parse(mezok[2]);
            this.partnerNeve= mezok[3];
            this.foKategoria= mezok[4];
            this.alKategoria = mezok[5];
                                              
        }
        public int Id { get => id; set => id = value; }
        // public DateTime Datum { get => datum; set => datum = value; }  // itt másodpercre pontosan írja ki az időt 12:00:00 órával kezdődően
        // public DateTime Datum { get => datum; set => datum.Date.ToLongDateString(); } 
        public string Datum { get => datum.Date.ToShortDateString(); }   // itt csak a nap, hónap és évet írja ki.
        public int Osszeg { get => osszeg; }
        public string PartnerNeve { get => partnerNeve; }
        public string FoKategoria { get => foKategoria; }
        public string AlKategoria { get => alKategoria; }
    }

}
