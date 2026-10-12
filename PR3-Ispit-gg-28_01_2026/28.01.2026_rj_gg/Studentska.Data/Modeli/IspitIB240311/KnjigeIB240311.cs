using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Studentska.Data.Modeli.IspitIB240311
{
    public class KnjigeIB240311
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public int BrojPrimjeraka { get; set; }
        public byte[] Slika { get; set; }

        public override string ToString()
        {
            return $"{Naziv} ({Autor})";
        }
    }
}
