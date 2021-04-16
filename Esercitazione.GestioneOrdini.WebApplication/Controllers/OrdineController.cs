using Esercitazione.GestioneOrdini.Entities;
using Esercitazione.GestioneOrdini.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esercitazione.GestioneOrdini.WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdineController : ControllerBase
    {
        private readonly IRepositoryOrdine repoOrdine;
        public OrdineController(IRepositoryOrdine repository)
        {
            this.repoOrdine = repository;
        }

        [HttpGet]
        public ActionResult GetOrdini()
        {
            return Ok(repoOrdine.listaOrdini());
        }

        [HttpGet("{id}")]
        public ActionResult GetOrdineByID(int id)
        {
            //var ordine = repoOrdine.listaOrdini().FirstOrDefault(i => i.Id == id);
            var ordine = repoOrdine.GetById(id);
            if (ordine == null)
            {
                return NotFound();
            }
            return Ok(ordine);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrdine(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            //var ordine = repoOrdine.listaOrdini().FirstOrDefault(i => i.Id == id);
            var ordine = repoOrdine.GetById(id);
            if (ordine == null)
            {
                return NotFound();
            }
            var result = repoOrdine.Delete(ordine);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        //Nella creazione vado solo ad inserire l'id dell'utente ed elimino il resto al di sotto

        [HttpPost]
        public ActionResult CreateOrdine( [FromBody] Ordine ordine)
        {
            if(ordine == null)
            {
                return BadRequest();
            }
            var result = repoOrdine.Create(ordine);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateOrdine(int id, [FromBody] Ordine ordine)
        {
            if (id < 0)
            {
                return BadRequest();
            }

            ordine.Id = id;

            var result = repoOrdine.Update(ordine);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
