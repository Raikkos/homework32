using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework3.Application;
using Homework3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework3.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly GetUsersInfoRequestHandler _getUsersInfoRequestHandler;

        public UsersController(GetUsersInfoRequestHandler getUsersInfoRequestHandler)
        {
            _getUsersInfoRequestHandler = getUsersInfoRequestHandler;
        }

        [HttpGet("{id}")]
        public Task<User> GetUserInfo(Guid id)
        {
            return _getUsersInfoRequestHandler.Handle(id);
        }
    }
}
