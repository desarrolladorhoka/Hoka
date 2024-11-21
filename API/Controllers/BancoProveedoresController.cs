using API.Models;
using API.Services.Interfaces;
using API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;


namespace API.Controllers
{
    public class BancoProveedoresController : ApiController
    {
        private readonly IBancoProveedoresService _service;

        public BancoProveedoresController()
        {
            _service = new BancoProveedoresService();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var data = _service.GetById(id);
            if (data == null)
                return NotFound();
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Add(BancoProveedores bancoProveedores)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Add(bancoProveedores);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Update(BancoProveedores bancoProveedores)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Update(bancoProveedores);
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
