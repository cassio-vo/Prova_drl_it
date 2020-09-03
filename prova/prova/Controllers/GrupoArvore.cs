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
    public class GrupoArvore : ControllerBase
    {
        IGrupoArvoreBusiness _grupoArvoreBusiness;
        private readonly LinkGenerator _linkGenerator;

        public GrupoArvore(IGrupoArvoreBusiness grupoArvoreBusiness, LinkGenerator generator)
        {
            _grupoArvoreBusiness = grupoArvoreBusiness;
            _linkGenerator = generator;
        }

        // GET: api/GrupoArvore
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(List<GrupoArvoreVO>))]
        [SwaggerResponse(204)]
        public IActionResult Get()
        {
            return Ok(_grupoArvoreBusiness.FindAll().Select(x => (GrupoArvoreVO)GetUrl.GerarLinks(
                x,
                nameof(Get),
                this.HttpContext, _linkGenerator)));
        }

        // GET: api/GrupoArvore/5
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(GrupoArvoreVO))]
        public IActionResult GetGrupoArvore(int id)
        {
            return Ok(GetUrl.GerarLinks(
                _grupoArvoreBusiness.FindById(id),
                nameof(GetGrupoArvore),
                this.HttpContext, _linkGenerator));
        }

        // POST: api/GrupoArvore
        [HttpPost(Name = "CreateGrupoArvore")]
        [SwaggerResponse(200, Type = typeof(GrupoArvoreVO))]
        public IActionResult Post([FromBody] GrupoArvoreVO grupoArvore)
        {
            return Ok(_grupoArvoreBusiness.Create(grupoArvore));
        }


        // PUT: api/GrupoArvore/5
        [HttpPut("{id}", Name = "UpdateGrupoArvore")]
        [SwaggerResponse(200, Type = typeof(GrupoArvoreVO))]
        public IActionResult Put(int id, [FromBody] GrupoArvoreVO grupoArvore)
        {
            return Ok(_grupoArvoreBusiness.Update(grupoArvore));
        }

        // DELETE: api/GrupoArvore/5
        [HttpDelete("{id}", Name = "DeleteGrupoArvore")]
        [SwaggerResponse(204)]
        public IActionResult Delete(int id)
        {
            _grupoArvoreBusiness.Delete(id);
            return NoContent();
        }
    }
}
