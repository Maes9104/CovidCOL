using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using CovidCol.Models;
using CovidCol.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidCol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/User
        [HttpGet]
        [Route("GetUsers")]
        public IActionResult Get()
        {
            var users = _userRepository.GetUsuarios();
            return new OkObjectResult(users);
        }

        // GET: api/User?id=5
        [HttpGet]
        [Route("id/{id:int}")]
        public IActionResult Get(int id)
        {
            var user = _userRepository.GetUsuarioById(id);
            return new OkObjectResult(user);
        }

        // GET: api/User/ByDocument/107255554
        [HttpGet]
        [Route("docNum/{docNum:long}")]
        public IActionResult Get(long docNum)
        {
            var user = _userRepository.GetUsuarioByDoc(docNum);
            return new OkObjectResult(user);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            using (var scope = new TransactionScope())
            {
                _userRepository.InsertUsuario(usuario);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = usuario.Id }, usuario);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            if (usuario != null)
            {
                using (var scope = new TransactionScope())
                {
                    _userRepository.UpdateUsuario(usuario);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userRepository.DeleteUsuario(id);
            return new OkResult();
        }
    }
}
