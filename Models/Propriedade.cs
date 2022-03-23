using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_ASP_mvc.Models
{
    public class Propriedade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Proprietary { get; set; }
        public DateTime CreationDate { get; set; }
    }
}