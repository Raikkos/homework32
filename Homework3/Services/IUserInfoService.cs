using Homework3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Services
{
    public interface IUserInfoService
    {
        Task<User> GetById(Guid id);
    }
}
