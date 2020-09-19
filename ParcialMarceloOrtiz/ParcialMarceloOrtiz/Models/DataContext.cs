

namespace ParcialMarceloOrtiz.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")//Constructor
        {

        }

        public System.Data.Entity.DbSet<ParcialMarceloOrtiz.Models.Country> Countries { get; set; }
    }
}