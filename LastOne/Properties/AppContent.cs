using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastOne.Properties
{
    class AppContent : DbContext
    {
        public AppContent()
            : base("Data Source=.;Initial Catalog=LastOne;Persist Security Info=True;User ID=sa;Password=123")
        {
        }
        public DbSet<SinhVien> sinhVienDbset { get; set; }
    }
}
