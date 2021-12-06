﻿using AuthContext.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EAD_CORE_V1.Controllers
{
    public class Loggin : Controller
    {
        private readonly TokenService _executaServicoAuth;
        public Loggin(TokenService executaServicoAuth)
        {
            _executaServicoAuth = executaServicoAuth;
        }

        [HttpPost]
        [Route("Home/loggin")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Access model)
        {
            model.email = "teste";
            //var user = DAL.Home.validaUsuario(model);
            //var ativo = DAL.Home.validaUsuarioAtivo(model);
            var user = model;
            var ativo = true;

            
            if (ativo)
            {
                if (model == null)
                    return NotFound(new { result = false, message = "Usuário ou senha inválidos" });

                var claim = new ClaimsIdentity(new Claim[]
                        {
                    new Claim(ClaimTypes.Name, user.email.ToString())                    
                    }, CookieAuthenticationDefaults.AuthenticationScheme);

                var token = _executaServicoAuth.GenerateToken(user, claim);
                var authProp = new AuthenticationProperties
                {
                    IssuedUtc = DateTime.UtcNow,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(25),
                    IsPersistent = true
                };
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claim),
                    authProp
                    );
                user.senha = "";

                return new
                {
                    result = true,
                    user = user,
                    token = token,
                    message = "Seja bem vindo " + user.nome
                };
            }
            else
            {
                var https = HttpContext.Request.IsHttps;
                var host = HttpContext.Request.Host.ToString();
                var scheme = HttpContext.Request.Scheme;
              //  DAL.Home.EmailConfirmacao(model.Email, host, scheme);
                return Json(new { result = false, message = "Cadastro ainda não está ativo, por favor verifique em seu e-mail o Link para a ativação." });
            }

        }

        [HttpPost]
        [Route("Home/logout")]
        public async Task<ActionResult<dynamic>> Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var a = User.Identity.Name;
            return true;
        }
    }
}
