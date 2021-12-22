using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gasgone.ORM.Data.DAO
{
   public  class CmandFournisseur
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        [ForeignKey("FournisseurID")]
        public Fournisseur Fournisseur { get; set; }
    }
}
