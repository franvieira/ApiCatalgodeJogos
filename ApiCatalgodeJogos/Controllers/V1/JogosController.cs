using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalgodeJogos.Controllers.V1
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {

        private readonly IJogoService _jogoService;

        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<object>>> Obter()
        {
            return Ok();
        }

        [HttpGet("{idJogo: guid}")]
        public async Task<ActionResult<object>> Obter(Guid idJogo)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<object>> InserirJogo(object jogo)
        {
            return Ok();
        }

        [HttpPut("{idJogo: guid}")]
        public async Task<ActionResult<object>> AtualizaJogo(Guid idJogo, object jogo)
        {
            return Ok();
        }

        [HttpPatch("{idJogo: guid}/preco/{preco:double}")]
        public async Task<ActionResult<object>> AtualizaJogo(Guid idJogo, double preco)
        {
            return Ok();
        }

        [HttpDelete("idJogo: guid")]
        public async Task<AcceptedResult> ApagarJogo(Guid idJogo)
        {
            return Ok();
        }
    }
}