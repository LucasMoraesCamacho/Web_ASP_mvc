using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Web_ASP_mvc.Models;

namespace Web_ASP_mvc.Context
{
    public class WebContext : DbContext
    {
        public WebContext() : base ("WebContext")
            {
            
            }

        public DbSet<Propriedade> Propriedades { get; set; }
    }
}