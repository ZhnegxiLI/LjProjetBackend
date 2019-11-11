using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace LjWebApplication.Auth
{
    public class AuthRepository : IAuthRepository
    {   
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string login(string username, string password)
        {
            string token = "";
            // Add login logic
            if (IsValidUserAndPasswordCombination(username,password))
            {
                token = GenerateToken(username);
            }

            return token;
        }

        /// <summary>
        /// Check the account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool IsValidUserAndPasswordCombination(string username, string password)
        {
            return !string.IsNullOrEmpty(username) && username == password;
        }

        /// <summary>
        /// TODO: send the user id 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private string GenerateToken(string username)
        {
            // TODO: configure the jwt
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.NameId, username),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };

            var token = new JwtSecurityToken(
                new JwtHeader(new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret Key You Devise")),//TODO: Add into the appsetting.json
                    SecurityAlgorithms.HmacSha256)),
                new JwtPayload("issuer", "audience", claims, null, DateTime.Now.AddMinutes(5)));
            //JwtPayload(string issuer, string audience, IEnumerable<Claim> claims, DateTime? notBefore, DateTime? expires);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
