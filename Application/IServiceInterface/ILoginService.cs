﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServiceInterface
{
    public interface ILoginService
    {
        public bool Login(string username, string password);
    }
}
