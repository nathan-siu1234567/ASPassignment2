/**
 * Names: Nathan Siu and mike Meissner
 * File Name foodContext.cs
 * File Description: This is the food connection
 * 
 * */
namespace ASPAssignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodContext : DbContext
    {
        public FoodContext()
            : base("name=FoodConnection")
        {
        }
        public virtual DbSet<food> Food { get; set; }
     
    }
}
