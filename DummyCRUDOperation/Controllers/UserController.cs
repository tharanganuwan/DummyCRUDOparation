using DomainLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DummyCRUDOperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllRecords() 
        {
            var responce = _service.GetAllRepo();
            return Ok(responce);
        }

        [HttpGet]
        [Route("get")]
        public IActionResult GetSingleRecords(long id)
        {
            var responce = _service.GetSingleRepo(id);
            return Ok(responce);
        }

        [HttpPost("add")]
        public IActionResult AddUser(User user)
        {
            return Ok(_service.AddUserRepo(user));
        }

        [HttpDelete]
        public IActionResult RemoveUser(long id)
        {
            return Ok(_service.RemoveUserRepo(id));
        }

        [HttpPut("update")]
        public IActionResult UpdateUser(User user)
        {
            return Ok(_service.UpdateUserRepo(user));
        }
    }
}
