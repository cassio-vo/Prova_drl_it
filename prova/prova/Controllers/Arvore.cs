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
    public class Arvore : ControllerBase
    {
        IArvoreBusiness _arvoreBusiness;
        private readonly LinkGenerator _linkGenerator;

        public Arvore(IArvoreBusiness arvoreBusiness, LinkGenerator generator)
        {
            _arvoreBusiness = arvoreBusiness;
            _linkGenerator = generator;
        }

        // GET: api/Arvore
        [HttpGet]
        [SwaggerResponse(200, Type = typeof(List<ArvoreVO>))]
        [SwaggerResponse(204)]
        public IActionResult Get()
        {
            return Ok(_arvoreBusiness.FindAll().Select(x => (ArvoreVO)GetUrl.GerarLinks(
                x,
                nameof(Get),
                this.HttpContext, _linkGenerator)));
        }

        // GET: api/Arvore/5
        [HttpGet("{id}")]
        [SwaggerResponse(200, Type = typeof(ArvoreVO))]
        public IActionResult GetArvore(int id)
        {
            return Ok(GetUrl.GerarLinks(
                _arvoreBusiness.FindById(id),
                nameof(GetArvore),
                this.HttpContext, _linkGenerator));
        }

        // POST: api/Arvore
        [HttpPost(Name = "CreateArvore")]
        [SwaggerResponse(200, Type = typeof(ArvoreVO))]
        public IActionResult Post([FromBody] ArvoreVO arvore)
        {
            return Ok(_arvoreBusiness.Create(arvore));
        }
        

        // PUT: api/Arvore/5
        [HttpPut("{id}", Name = "UpdateArvore")]
        [SwaggerResponse(200, Type = typeof(ArvoreVO))]
        public IActionResult Put(int id, [FromBody] ArvoreVO arvore)
        {
            return Ok(_arvoreBusiness.Update(arvore));
        }

        // DELETE: api/Arvore/5
        [HttpDelete("{id}", Name = "DeleteArvore")]
        [SwaggerResponse(204)]
        public IActionResult Delete(int id)
        {
            _arvoreBusiness.Delete(id);
            return NoContent();
        }
    }
}
