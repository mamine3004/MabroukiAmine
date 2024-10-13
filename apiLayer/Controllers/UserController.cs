using coreLayer;
using DaoLayer.Utilisateurs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUtilisateur _utilisateurservice;

        public UserController(IUtilisateur utilisateurservice)
        {
            _utilisateurservice = utilisateurservice;
        }

        // GET: api/<UserController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<UserController>/5
        [HttpGet("Authenticafication/{login}/pass/{password}")]
        public Utilisateur? Authenticafication(string login,string password)
        {
            Utilisateur user = _utilisateurservice.authentification(login,password);
            return user;
        }

        // POST api/<UserController>
        [HttpPost("inscription")]
        public int Inscription([FromBody] Utilisateur user)
        {
            return _utilisateurservice.inscription(user);
        }

        //// PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
