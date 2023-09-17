using Microsoft.EntityFrameworkCore;
using SLN8Dapper.DATA.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLN8Dapper.DATA.DBContext
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }
        public virtual DbSet<TblUserRegistration> tblUserRegistration { get; set; }
        public virtual DbSet<TblUserLogin> tblUserLogin { get; set; }
    }
}
