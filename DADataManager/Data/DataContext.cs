﻿using DADataManager.Models;
using Microsoft.EntityFrameworkCore;

namespace DADataManager.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PhotoForDetailedDto> Photos { get; set; }
    }
}
