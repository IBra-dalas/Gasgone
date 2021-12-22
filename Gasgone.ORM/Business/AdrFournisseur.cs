using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Business
{
    public class AdrFournisseur
    {

        public int Id { get; set; }
        public int CodePostale { get; set; }
        public int Numero { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public Fournisseur fournisseur { get; set; }
    }
}
