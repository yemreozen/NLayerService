using System.ComponentModel.DataAnnotations;

namespace JWTWebApi.Model.LoginRegisterModels
{
    public class LoginModel
    {
        public string? Username { get; set; }

        public string? Password { get; set; }

    }
}
