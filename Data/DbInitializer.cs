using reforma_agraria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reforma_agraria.Data
{
    public class DbInitializer
    {
        public static void Initialize(ReformaAgrariaDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any kabupaten.
            if (context.KabupatenModel.Any())
            {
                return;   // DB has been seeded
            }

            var kabupatenModel = new Region[]
            {
            new Region{Id=1,Name="Sigi",Type=RegionType.KABUPATEN,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=2,Name="Dolo",Type=RegionType.KECAMATAN,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=3,Name="Gumbasa",Type=RegionType.KECAMATAN,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=4,Name="Kinovaro",Type=RegionType.KECAMATAN,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=5,Name="Kabobona",Type=RegionType.DESA,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=6,Name="Tulo",Type=RegionType.DESA,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=7,Name="Pakuli",Type=RegionType.DESA,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now},
            new Region{Id=8,Name="Doda",Type=RegionType.DESA,Parent=null, DateCreated=DateTime.Now, DateModified=DateTime.Now}
            };
            foreach (Region kb in kabupatenModel)
            {
                context.KabupatenModel.Add(kb);
            }
            context.SaveChanges();
        }
    }
}
