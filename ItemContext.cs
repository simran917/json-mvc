using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace json_mvc
{
    public class ItemContext : DbContext
    {
        /*public ItemContext() : base("Server=tcp:iamsimran.database.windows.net,1433;Initial Catalog=mydatabase;Persist Security Info=False;User ID=Simran;Password=sim@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        {

        }*/
        public DbSet<item> items
        {
            get;
            set;
        }
    }
}
