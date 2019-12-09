using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Login
    {
        public Int64 Token { get; set; }
        public Int64 ID { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Email { get; set; }
    }



}


