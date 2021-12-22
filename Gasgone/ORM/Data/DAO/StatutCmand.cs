using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Data.DAO
{
    public class FactureCommande
    {
        public int Id { get; set; }
        [ForeignKey("CommandeID")]
        public Commande Commande { get; set; }

    }
}
