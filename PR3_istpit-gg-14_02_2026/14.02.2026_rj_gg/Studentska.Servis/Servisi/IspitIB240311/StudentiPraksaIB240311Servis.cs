using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IspitIB240311;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IspitIB240311
{
    public class StudentiPraksaIB240311Servis:BaseServis<StudentiPraksaIB240311>
    {
        public List<StudentiPraksaIB240311> GetAll()
        {
            return _dbContext.StudentiPraksaIB240311.Include(x => x.Student).Include(x => x.Kompanija).ThenInclude(x => x.Grad).ToList();
        }
    }
}
