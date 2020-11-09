﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Database : DbContext
    {
        public Database(DbContextOptions options) : base(options)
        {
        }

        [NotNull]
        public DbSet<Content> Content { get; set; }
    }
}
