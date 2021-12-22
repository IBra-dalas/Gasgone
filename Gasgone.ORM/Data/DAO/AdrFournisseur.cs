using System.ComponentModel.DataAnnotations.Schema;


namespace Gasgone.ORM.Data.DAO
{
   public  class AdrFournisseur
    {
        public int Id { get; set; }
        public int CodePostale { get; set; }
        public int Numero { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        [ForeignKey("FournisseurID")]
        public Fournisseur fournisseur { get; set; }
    }
}
