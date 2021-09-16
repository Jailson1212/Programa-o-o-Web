using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using a.Areas.Seguranca.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace a.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAplicacao() : base("IdentityDb")
        { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(new IdentityDbInit());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }

    }
    public class IdentityDbInit : DropCreateDatabaseIfModelChanges<IdentityDbContextAplicacao>
    {
    }
}