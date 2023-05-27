using Microsoft.AspNetCore.Mvc;



namespace Resgistro.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CadastroController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API de Cadastro");
        }

        [HttpPost]
        public IActionResult Post([FromBody] CadastroModel model)
        {
            // Faça o processamento do cadastro aqui

            // Exemplo de retorno com dados do cadastro
            return Ok(model);
        }

        public class CadastroModel
        {
        }
    }

    public class CadastroModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}
