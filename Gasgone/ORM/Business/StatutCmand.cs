using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Business
{
    public class StatutCommande
    {
        public int Id { get; set; }
        [ForeignKey("CommandeID")]
        public Commande Commande { get; set; }

    }
}
