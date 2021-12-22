using Gasgone.ORM.Data.DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Data
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Fournisseur> Fournisseur { get; set; }

        public DbSet<AdrFournisseur> AdrFournisseur { get; set; }

        public DbSet<CmandFournisseur> CmandFournisseur { get; set; }
    }
}
