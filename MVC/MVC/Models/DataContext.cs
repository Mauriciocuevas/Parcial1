﻿using System.Data.Entity;

namespace MVC.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC.Models.Friend> Friends { get; set; }
    }
}