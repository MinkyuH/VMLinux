using System;
using System.Security.Claims;
using AspDotNEtCore.Repositories;
using AspDotNEtCore.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNEtCore.Controllers
{
    [Route("api/authentication")]
    public class AuthenticationController : Controller
    {
        private CustomAuthenticationService authenticationService;
        private UserRepository userRepository;

        public AuthenticationController(UserRepository userRepository, CustomAuthenticationService authenticationService)
        {
            this.userRepository = userRepository;
            this.authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginModel loginModel)
        {
            var user = userRepository.GetUser(loginModel.ID);
            if (authenticationService.AuthenticateUser(user, loginModel))
            {
                var claimsPrincipal = new ClaimsPrincipal();
                var claimsIdendity = new ClaimsIdentity();
                claimsIdendity.AddClaim(new Claim("name", user.ID));
                claimsPrincipal.AddIdentity(claimsIdendity);

                HttpContext.SignInAsync("COOKIE_SCHEME", claimsPrincipal);
            }

            return new JsonResult("");
        }




        [HttpGet]
        [Authorize]
        public IActionResult testAuthentication() {
            var user = HttpContext.User;
            Console.WriteLine(user);
            return new JsonResult(user);
        }

    }

    public class LoginModel {
        public string ID { get; set; }
        public string password { get; set; }
    }


}
