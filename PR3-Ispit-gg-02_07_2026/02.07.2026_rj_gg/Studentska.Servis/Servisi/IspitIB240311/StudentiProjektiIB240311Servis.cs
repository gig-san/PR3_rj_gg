using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IspitIB240311;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IspitIB240311
{
    public class StudentiProjektiIB240311Servis: BaseServis<StudentiProjektiIB240311>
    {
        public List<StudentiProjektiIB240311> GetAll()
        {
            return _dbContext.StudentiProjektiIB240311.Include(x => x.Student).Include(x => x.Projekt).ToList();
        }
    }
}
