using JWTDemo.Models;
using System;
namespace JWTAuthentication_TokenBarer.Services
{
    public interface IAuthenticateService
    {
        Student Authenticate(String UserName, String Password);
    }
}