using a.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using a.Areas.Seguranca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace a.Infraestrutura
{
    public class GerenciadorUsuario : UserManager<Usuarios>
    {
        public GerenciadorUsuario(IUserStore<Usuarios> store) : base(store)
        { }
        public static GerenciadorUsuario Create(IdentityFactoryOptions<GerenciadorUsuario> options, IOwinContext context)
        {
            IdentityDbContextAplicacao db = context.Get<IdentityDbContextAplicacao>();
            GerenciadorUsuario manager = new GerenciadorUsuario(new UserStore<Usuarios>(db));
            return manager;
        }
    }
}
