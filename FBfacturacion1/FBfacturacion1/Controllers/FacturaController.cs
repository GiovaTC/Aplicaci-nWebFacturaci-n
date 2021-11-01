using FBfacturacion1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FBfacturacion1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public FacturaController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<FacturaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listClientes = await _context.facturacion.ToListAsync();
                return Ok(listClientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FacturaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CFacturacion cliente)
        {
            try
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<FacturaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CFacturacion cliente)
        {
            try
            {
                if (id != cliente.Id)
                {
                    return NotFound();
                }
                _context.Update(cliente);
                await _context.SaveChangesAsync();
                return Ok(new { message = "El cliente fue actualizado con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _context.facturacion.FindAsync(id);
                if(cliente == null)
                {
                    return NotFound();
                }
                _context.facturacion.Remove(cliente);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La tarjeta fue eliminada con exito" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
