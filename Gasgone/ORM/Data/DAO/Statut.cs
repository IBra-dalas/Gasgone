using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Data.DAO
{
    public class Statut
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        [ForeignKey("CommandeID")]
        public Commande commande { get; set; }
    }
}
