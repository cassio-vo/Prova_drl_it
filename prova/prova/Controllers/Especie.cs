using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using prova.Business;
using prova.Data.VO;
using prova.HATEOAS;
using Swashbuckle.AspNetCore.Annotations;

namespace prova.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Especie : ControllerBase
    {
        IEspecieBusiness _especieBusiness;
        private readonly LinkGenerator _linkGenerator;

        public Especie(IEspecieBusiness especieBusiness, LinkGenerator generator)
        {
            _especieBusiness = especieBusiness;
            _linkGenerator = generator;
        }

        // GET: api/Especie
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(List<EspecieVO>))]
        [SwaggerResponse(204)]
        public IActionResult Get()
        {
            return Ok(_especieBusiness.FindAll().Select(x => (EspecieVO)GetUrl.GerarLinks(
                x,
                nameof(Get),
                this.HttpContext, _linkGenerator)));
        }

        // GET: api/Especie/5
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(EspecieVO))]
        public IActionResult GetEspecie(int id)
        {
            return Ok(GetUrl.GerarLinks(
                _especieBusiness.FindById(id),
                nameof(GetEspecie),
                this.HttpContext, _linkGenerator));
        }

        // POST: api/Especie
        [HttpPost(Name = "CreateEspecie")]
        [SwaggerResponse(200, Type = typeof(EspecieVO))]
        public IActionResult Post([FromBody] EspecieVO especie)
        {
            return Ok(_especieBusiness.Create(especie));
        }


        // PUT: api/Especie/5
        [HttpPut("{id}", Name = "UpdateEspecie")]
        [SwaggerResponse(200, Type = typeof(EspecieVO))]
        public IActionResult Put(int id, [FromBody] EspecieVO especie)
        {
            return Ok(_especieBusiness.Update(especie));
        }

        // DELETE: api/Especie/5
        [HttpDelete("{id}", Name = "DeleteEspecie")]
        [SwaggerResponse(204)]
        public IActionResult Delete(int id)
        {
            _especieBusiness.Delete(id);
            return NoContent();
        }
    }
}
