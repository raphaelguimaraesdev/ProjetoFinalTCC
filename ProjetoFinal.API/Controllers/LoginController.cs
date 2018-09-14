using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal.Compartilhado.ObjetoNegocio;

namespace ProjetoFinal.API.Controllers
{
    [ApiVersion("V1")]
    [Route("api/Login")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpPost]
        public string Logar([FromBody]Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // return BadRequest();
            }

            return "Logado";
        }
    }
}