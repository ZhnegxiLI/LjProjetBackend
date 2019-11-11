using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web.Http.ModelBinding;
using LjData.Models.ViewModel;
using LjDataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace LjDataAccess.Repositories
{
    public class AuthRepositoryRepository:IAuthRepository
    {
        private readonly ERPDATA2Context context;

        public AuthRepositoryRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public async System.Threading.Tasks.Task<string> LoginAsync(User user)
        {
            string token = "";
            string username = user.Name;
            string password = user.Password;
            // Add login logic
            if (await IsValidUserAndPasswordCombinationAsync(username, password))
            {
                token = GenerateToken(user.Id);
            }

            return token;
        }

    
        private async System.Threading.Tasks.Task<bool> IsValidUserAndPasswordCombinationAsync(string username, string password)
        {
            var user = await context.User.Where(p => p.Name == username && p.Password == password).FirstOrDefaultAsync();
            return user!=null;
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
