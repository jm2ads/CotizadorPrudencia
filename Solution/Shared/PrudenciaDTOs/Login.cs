using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project.Shared.PrudenciaDTOs
{
    //[Keyless]
    [NotMapped]
    public class Login
    {

        public string accessToken { get; set; }


        public string accessTokenExpirationDate { get; set; }
        public string refreshToken { get; set; }
        public string refreshTokenExpirationDate { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string codigoTitular { get; set; }
        public string[] roles { get; set; }

     
    }
}
