using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Business
{
    public class Statut
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public Commande commande { get; set; }

    }
}
