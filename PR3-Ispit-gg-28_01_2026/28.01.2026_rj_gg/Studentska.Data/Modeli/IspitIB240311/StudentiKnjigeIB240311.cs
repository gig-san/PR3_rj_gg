using Studentska.Data.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IspitIB240311
{
    public class StudentiKnjigeIB240311
    {
        public int Id {get;set;}
	    public int StudentId {get;set;}
        public Student Student {get;set;}

	    public int KnjigaId {get;set;}
        public KnjigeIB240311 Knjiga { get;set;}    
	    public DateTime DatumIznajmljivanja {get;set;}
	    public DateTime? DatumVracanja { get; set; }

        public bool Vracena => DatumVracanja == null ? false : true;

    }
}
