using System.Data.Entity;

namespace API.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

       
    }
}