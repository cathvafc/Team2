using System;
using System.Collections.Generic;


namespace Team2.Models
{
    public partial class User
    {

        //Atributos del modelo User
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
