﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusunessLogic.Interfaces
{
    public interface IAuthManager
    {
        UserDTO LogIn(string login, string password);
    }
}