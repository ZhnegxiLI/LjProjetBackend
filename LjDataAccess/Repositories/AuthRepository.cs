using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using LjData.Models;
//using System.Web.Http.ModelBinding;
using LjData.Models.ViewModel;
using LjDataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace LjDataAccess.Repositories
{
    public class AuthRepository:IAuthRepository
    {
        private readonly ERPDATA2Context context;

        public AuthRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public dynamic Login(User user)
        {
            string token = "";
            string userId = user.Id;
            string password = user.Password;
            // Add login logic
            if (IsValidUserAndPasswordCombination(userId, password))
            {
                string entrepriseType = context.Personel.Where(p => p.EmpnPsl == user.Id).Select(p => p.PlntPsl)
                    .FirstOrDefault();
                token = GenerateToken(user.Id);
                return new
                {
                    token = token,
                    permission = getUserPermissionById(user.Id),
                    entrepriseType = entrepriseType,
                    accountInfo = context.CpnyInfo.Where(p=>p.entrepriseType == entrepriseType).FirstOrDefault()
                };
            }

            return null;

        }

        public List<dynamic> GetUserList()
        {
            var result = (from u in context.User
                join p in context.Personel on u.Id equals p.EmpnPsl
                where p.RsdtPsl == null // 离职日期
                select new
                {
                    id = u.Id,
                    username = u.Name
                }).ToList<dynamic>();
            return result;
        }


        private bool IsValidUserAndPasswordCombination(string userId, string password)
        {
            var e = encode(password);
            var user = context.User.Where(p => p.Id == userId && p.Password == encode(password)).FirstOrDefault();
            return user!=null;
        }

        /// <summary>
        /// TODO: send the user id 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private string GenerateToken(string username)
        {
            //// TODO: configure the jwt
            //var claims = new Claim[]
            //{
            //    new Claim(ClaimTypes.Name, username),
            //    new Claim(JwtRegisteredClaimNames.NameId, username),
            //    new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
            //    new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            //};

            //var token = new JwtSecurityToken(
            //    new JwtHeader(new SigningCredentials(
            //        new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret Key You Devise")),//TODO: Add into the appsetting.json
            //        SecurityAlgorithms.HmacSha256)),
            //    new JwtPayload("issuer", "audience", claims, null, DateTime.Now.AddMinutes(5)));
            ////JwtPayload(string issuer, string audience, IEnumerable<Claim> claims, DateTime? notBefore, DateTime? expires);
            //return new JwtSecurityTokenHandler().WriteToken(token);
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };

            var token = new JwtSecurityToken(
                new JwtHeader(new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Secret Key You Devise")),
                    SecurityAlgorithms.HmacSha256)),
                new JwtPayload(claims));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public int CheckAvailabilityOfToken(string token)
        {
            if (token != null) // Add issuer and audience and expiration time check
            {
                return 1;
            }

            return 0;
        }

        // Encode password function
         private string encode(string arg)
        {
            string res = "";
            string codage = "C3D4E5";
            int codeLen = codage.Length;
            int m = 0;
            for (int i = 0; i < arg.Length; i++, m++)
            {
                if (m >= codeLen) m = 0;
                res += (char)(arg[i] + codage[m]);
            }

            res = res + "cSdT";
            return res;
        }

         public List<dynamic> getUserPermissionById(string userId)
         {
             var result = from up in context.MobileUserPermission
                 join p in context.MobilePermission on up.PermissionId equals p.Id
                 where up.UserId == userId
                 select new
                 {
                     userId = up.UserId,
                     permissionId = p.Id,
                     permissionCode = p.Code,
                     permissionLabel = p.Label
                 };
             return result.ToList<dynamic>();
         }

    }
}
