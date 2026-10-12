using Microsoft.EntityFrameworkCore;
using Studentska.Data.Modeli.IspitIB240311;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.Servis.Servisi.IspitIB240311
{
    public class KompanijeIB240311Servis: BaseServis<KompanijeIB240311>
    {
        public List<KompanijeIB240311> GetAll()
        {
            return _dbContext.KompanijeIB240311.Include(x=> x.Grad).ToList();
        }
    }
}
