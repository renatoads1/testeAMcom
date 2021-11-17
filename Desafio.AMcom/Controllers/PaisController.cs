using Desafio.AMcom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Desafio.AMcom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private ILogger<PaisController> _logger;

        public PaisController(ILogger<PaisController> logger)
        {
            _logger = logger;
        }

        // GET: api/<PaisController>
        [HttpGet]
        public object Get()
        {
            try
            {
                Paises paises = new Paises();
                var ret = paises.PaisesAll();
                return ret;
            }
            catch (Exception)
            {
                _logger.LogInformation("Ocorreu um problema ao Buscar os dados");
                return NotFound();
            }
            
        }
        // GET: api/<PaisController>
        [HttpGet("api/[controller]/{sigla}")]
        public object Get(string sigla)
        {
            try
            {
                Paises paises = new Paises();
                var ret = paises.PaisesAll();
                var pais = ret.Where(a => a.sigla.Contains(sigla)).FirstOrDefault();
                return pais;
            }
            catch (Exception)
            {
                _logger.LogInformation("Ocorreu um problema ao Buscar os dados");
                return NotFound();
            }

        }

    }
}
