using DataAccess.Concrete;
using Entities.Concrete;
using FireSharp.Config;
using FireSharp.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using.FireSharp.Config;
using.FireSharp.Response;
using.FireSharp.Interfaces;


namespace DataAccess.Concrete.EntitityFramework
{
    public class HealthyLifeContext
    {
    public IFirebaseConfing _firebaseConfing = new IFirebaseConfing
        {
            AuthSecret = "egIh6JmQJH07LyLv7oP9MSRc5U3RPrfIHILyChbk",
            BasePath = "https://healthylifefb-ff6fe-default-rtdb.firebaseio.com"
            
        };
    
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Person { get; set; }



    }
}
