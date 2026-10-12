using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IspitIB240311
{
    public class StudentiProjektiIB240311
    {
       
		public int Id {get;set;}
		public int StudentId {get;set;}
		public Student Student {get;set;}	
		public int ProjektId {get;set;}
		public ProjektiIB240311 Projekt { get;set;}

		public DateTime DatumPrijave {get;set;}
		public string StatusPrijave {get;set;}
		public DateTime? DatumPromjene {get;set;}
		public bool Arhivirana { get; set; }

		public DateTime RokZavrsetka => Projekt.RokZavrsetka;
		public string StanjePrijave => Arhivirana ? "Arhivirana" : "Aktivna";


    }
}
