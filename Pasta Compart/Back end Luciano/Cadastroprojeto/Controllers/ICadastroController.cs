using Microsoft.AspNetCore.Mvc;

namespace Resgistro.Controllers
{
    public interface ICadastroController
    {
        IActionResult Cadastro([FromBody] CadastroController.CadastroModel model);
    }
}