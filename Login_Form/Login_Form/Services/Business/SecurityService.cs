using Login_Form.Models;
using Login_Form.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_Form.Services.Business
{
    public class SecurityService
    {
        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(userModel user) 
        {
            return daoService.findByUser(user);
        }
    }
}