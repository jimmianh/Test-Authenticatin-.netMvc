using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;

namespace WebApplication6.Data
{
    public class Context : IdentityDbContext<User>
    {
        public Context() : base("NorthwindContex")
        {
        }
    }
}