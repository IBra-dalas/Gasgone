using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Business
{
    public class CommandeFournisseur
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public Fournisseur Fournisseur { get; set; }

    }
}
