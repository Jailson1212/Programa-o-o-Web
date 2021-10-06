using Modeloa.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a.Areas.Home.Models
{
    public class Interface
    {
        public string Nome { get; set; }
        public string HomeId { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}