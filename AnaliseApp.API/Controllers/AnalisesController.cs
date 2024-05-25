using AnaliseApp.API.DTOs;
using AnaliseApp.Infra.Data;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnaliseApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalisesController : ControllerBase
    {
        [HttpGet("{id}/{dataInicio}/{dataFim}")]
        public IActionResult GetById(int id, DateTime dataInicio, DateTime dataFim)
        {

           try
            {
                var repository = new Repository();
                return StatusCode(200, repository.GetById(id, dataInicio, dataFim));
            }
            catch (Exception e)
            {
                return StatusCode(501, new { e.Message });
            }

        }
    }

}
