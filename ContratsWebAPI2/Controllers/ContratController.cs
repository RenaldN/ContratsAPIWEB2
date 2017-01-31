using ContratsWebAPI2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContratsWebAPI2.Controllers
{
    public class ContratController : ApiController
    {
        [HttpGet]
        [Route("Contrat")]
        public Contrat Get()
        {
            return new Models.Contrat()
            {
                Id = 1,
                Nom = "Contrat1",
                Produits = new List<Produit>() {
                    new Produit() { Id = 1, Nom = "Produit1" },
                    new Produit() { Id = 2, Nom = "Produit2" }
                }
            };
        }
    }
}
