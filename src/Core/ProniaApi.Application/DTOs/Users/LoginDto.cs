﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProniaApi.Application.DTOs.Users
{
    public record LoginDto(string UserNameOrEmail, string Password);
}
