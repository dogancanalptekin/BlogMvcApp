﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BlogMvcApp.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("blogDb")
        {
            Database.SetInitializer(new BlogInitializer());
        }

        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}