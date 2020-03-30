using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpine_Sky_House_v1._0._0.Models
{
    public class Login
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public Guid? PasswordHash { get; set; }
    }
}
