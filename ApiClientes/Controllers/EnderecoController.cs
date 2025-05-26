using ApiClientes.Services;
using ApiClientes.Services.DTOs;
using ApiClientes.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiClientes.Controllers
{
    [Route("api/clientes/{clienteId}/enderecos")]
    [ApiController]
    public class EnderecosController : ControllerBase
    {
        private readonly EnderecoService _service;

        public EnderecosController(EnderecoService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<EnderecoDTO> Adicionar(int clienteId, [FromBody] CriarEnderecoDTO body)
        {
            try
            {
                var response = _service.Criar(clienteId, body);
                return Ok(response);
            }
            catch (BadRequestException e)
            {
                return BadRequest(e.Message);
            }
            catch (NotFoundException e)
            {
                return StatusCode(404, e.Message);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<EnderecoDTO>> BuscarTodos(int clienteId)
        {
            try
            {
                var response = _service.BuscarTodos(clienteId);
                return Ok(response);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<EnderecoDTO> BuscarPorId(int clienteId, int id)
        {
            try
            {
                var response = _service.BuscarPorId(clienteId, id);
                return Ok(response);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<EnderecoDTO> Atualizar(int clienteId, int id, [FromBody] CriarEnderecoDTO body)
        {
            try
            {
                var response = _service.Atualizar(clienteId, id, body);
                return Ok(response);
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int clienteId, int id)
        {
            try
            {
                _service.Deletar(clienteId, id);
                return NoContent();
            }
            catch (System.Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
