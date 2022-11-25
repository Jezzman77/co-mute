using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace CoMute.Web.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
       
    }
}
