using System;
using AspDotNEtCore.Controllers;
using AspDotNEtCore.Repositories;

namespace AspDotNEtCore.Services
{
    public class CustomAuthenticationService
    {
        public CustomAuthenticationService()
        {
            
        }

        public bool AuthenticateUser(User user, LoginModel loginModel)
        {
            if (user.Password == loginModel.password && user.ID == loginModel.ID)
            {
                return true;
            }
            return false;
        }
    }
}
