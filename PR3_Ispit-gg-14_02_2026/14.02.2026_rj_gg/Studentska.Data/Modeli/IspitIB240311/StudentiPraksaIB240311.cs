using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IspitIB240311
{
    public class StudentiPraksaIB240311
    {

      
	    public int Id {get;set;}
	    public int StudentId {get;set;}
		public Student Student { get;set;}


        public int KompanijaId {get;set;}
		public KompanijeIB240311 Kompanija { get;set;}

        public DateTime DatumPrijave {get;set;}
	    public string Status {get;set;}
	    public DateTime? DatumPromjene { get; set; }

        public string Grad => Kompanija.Grad.Naziv;


    }
}
