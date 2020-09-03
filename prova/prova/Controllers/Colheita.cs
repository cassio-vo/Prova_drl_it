using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using prova.Business.Implmentations;
using prova.Data.VO;
using prova.HATEOAS;
using Swashbuckle.AspNetCore.Annotations;

namespace prova.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Colheita : ControllerBase
    {
        IColheitaBusiness _colheitaBusiness;
        private readonly LinkGenerator _linkGenerator;

        public Colheita(IColheitaBusiness colheitaBusiness, LinkGenerator generator)
        {
            _colheitaBusiness = colheitaBusiness;
            _linkGenerator = generator;
        }

        // GET: api/Colheita
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(List<ColheitaVO>))]
        [SwaggerResponse(204)]
        public IActionResult Get()
        {
            return Ok(_colheitaBusiness.FindAll().Select(x => (ColheitaVO)GetUrl.GerarLinks(
                x,
                nameof(Get),
                this.HttpContext, _linkGenerator)));
        }

        // GET: api/Colheita/5
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(ColheitaVO))]
        public IActionResult GetColheita(int id)
        {
            return Ok(GetUrl.GerarLinks(
                _colheitaBusiness.FindById(id),
                nameof(GetColheita),
                this.HttpContext, _linkGenerator));
        }

        // POST: api/Colheita
        [HttpPost(Name = "CreateColheita")]
        [SwaggerResponse(200, Type = typeof(ColheitaVO))]
        public IActionResult Post([FromBody] ColheitaVO colheita)
        {
            return Ok(_colheitaBusiness.Create(colheita));
        }


        // PUT: api/Colheita/5
        [HttpPut("{id}", Name = "UpdateColheita")]
        [SwaggerResponse(200, Type = typeof(ColheitaVO))]
        public IActionResult Put(int id, [FromBody] ColheitaVO colheita)
        {
            return Ok(_colheitaBusiness.Update(colheita));
        }

        // DELETE: api/Colheita/5
        [HttpDelete("{id}", Name = "DeleteColheita")]
        [SwaggerResponse(204)]
        public IActionResult Delete(int id)
        {
            _colheitaBusiness.Delete(id);
            return NoContent();
        }
    }
}
