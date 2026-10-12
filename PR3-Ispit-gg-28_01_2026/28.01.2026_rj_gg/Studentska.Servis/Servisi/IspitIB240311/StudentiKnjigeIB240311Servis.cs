using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IspitIB240311;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IspitIB240311
{
    public class StudentiKnjigeIB240311Servis: BaseServis<StudentiKnjigeIB240311>
    {
        public List<StudentiKnjigeIB240311> GetAll()
        {
            return _dbContext.StudentiKnjigeIB240311.Include(x => x.Student).Include(x => x.Knjiga).ToList();
        }
    }
}
