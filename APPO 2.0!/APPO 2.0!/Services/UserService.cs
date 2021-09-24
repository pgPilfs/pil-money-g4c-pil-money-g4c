using APPO_2._0_.Models;
using APPO_2._0_.Models.Common;
using APPO_2._0_.Models.ViewModels;
using APPO_2._0_.Response;
using APPO_2._0_.Tools;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace APPO_2._0_.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        public UserResponse Auth(UsuarioViewModel oModel)
        {
            UserResponse userresponse = new UserResponse();
            using (var db = new APPO20Context())
            {
                string spassword = Encrypt.GetSHA256(oModel.Password);
                var usuario = db.Usuarios.Where(d => d.Mail == oModel.Mail && d.Password == spassword).FirstOrDefault();

                if (usuario ==  null)
                {
                    return null;
                }
                userresponse.Email = usuario.Mail;
                userresponse.Token = GetToken(usuario);

            }
            return userresponse;

            
        }

        private string GetToken(Usuario usuario)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var llave = Encoding.ASCII.GetBytes(_appSettings.Secreto);
            var tokenDescriptor = new SecurityTokenDescriptor 
            {
                Subject = new ClaimsIdentity(
                    new Claim[] 
                    {
                        new Claim(ClaimTypes.NameIdentifier, usuario.IdUsuario.ToString()),
                         new Claim(ClaimTypes.Email, usuario.Mail)
                    }),
                Expires = DateTime.UtcNow.AddDays(80),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
