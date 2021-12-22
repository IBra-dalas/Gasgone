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

        public DbSet<AdresseFournisseur> AdrFournisseur { get; set; }

        public DbSet<CommandeFournisseur> CmandFournisseur { get; set; }

        public DbSet<StatutCommande> StatutCmand { get; set; }

        public DbSet<FactureCommande> FactureCmand { get; set; }

        public DbSet<CommandeArticle> CmandArticle { get; set; }

        public DbSet<StatutCommande> StatutCmand { get; set; }

        public DbSet<Statut> Statut { get; set; }

    }
}
