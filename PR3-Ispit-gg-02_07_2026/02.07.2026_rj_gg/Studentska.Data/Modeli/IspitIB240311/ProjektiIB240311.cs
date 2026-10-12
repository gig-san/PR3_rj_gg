using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IspitIB240311
{
    public class ProjektiIB240311
    {
        	public int Id {get;set;}
			public string Naziv {get;set;}
			public byte[] Logo {get;set;}
			public DateTime RokZavrsetka {get;set;}
			public int MaxBrStudenata {get;set;}
			public bool Aktivan {get;set;}
			public string? Napomena { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
