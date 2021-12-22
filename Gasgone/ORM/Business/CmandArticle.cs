using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasgone.ORM.Business
{
    public class CommandeArticle
    {
        public int Id { get; set; }
        public DateTime DateCommande { get; set; }
        public Article Article { get; set; }

    }
}
