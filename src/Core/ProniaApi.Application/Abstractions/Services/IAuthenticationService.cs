using ProniaApi.Application.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.Abstractions.Services
{
    public interface IAuthenticationService
    {
        Task Regoster(RegisterDto dto);
        Task<string> Login(LoginDto dto);
    }
}
