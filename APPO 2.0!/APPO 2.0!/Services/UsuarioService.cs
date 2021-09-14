using APPO_2._0_.Models;
using APPO_2._0_.Models.Commoon;
using APPO_2._0_.Models.Response;
using APPO_2._0_.Tools;
using APPO_2._0_.ViewModels;
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
    public class UsuarioService : IUsuarioService
    {
        private readonly AppSettings _appSettings;

        public UsuarioService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;

        }
        public UserResponse Auth(UsuarioViewModel model)
        {
            UserResponse userresponse = new UserResponse();
            
            using (var db = new APPO20Context())
            {
                string spassword = Encrypt.GetSHA256(model.Password);
                var usuario = db.Usuarios.Where(d => d.Mail == model.Mail && d.Password == spassword).FirstOrDefault();

                if (usuario == null)
                {
                    return null;
                }
                userresponse.Mail = usuario.Mail;
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
                        new Claim(ClaimTypes.NameIdentifier, usuario.Dni.ToString()),
                        new Claim(ClaimTypes.NameIdentifier, usuario.Mail)
                    }
                    ),
                Expires = DateTime.UtcNow.AddDays(720),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(llave), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        } 
    }
}
