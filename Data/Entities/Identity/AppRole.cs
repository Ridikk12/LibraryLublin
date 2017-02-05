using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class AppRole : IdentityRole
    {

        public AppRole() : base() { }
        public AppRole(string roleName) : base(roleName)
        {
        }
    }
}
