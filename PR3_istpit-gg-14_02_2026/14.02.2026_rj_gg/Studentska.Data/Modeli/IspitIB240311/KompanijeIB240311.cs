using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IspitIB240311
{
    public class KompanijeIB240311
    {

      
		public int Id {get;set;}
		public string Naziv {get;set;}
		public int GradId {get;set;}
		public Grad Grad { get;set;}
		public string Adresa {get;set;}
		public string Url {get;set;}
		public byte[] Slika {get;set;}
		public int MaxBrojStudenata {get;set;}
		public bool Aktivna { get; set; }

        public override string ToString()
        {
			return Naziv;
        }
    }
}
