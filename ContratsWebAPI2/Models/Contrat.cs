using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContratsWebAPI2.Models
{
    public class Contrat
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public List<Produit> Produits { get; set; }
    }
}