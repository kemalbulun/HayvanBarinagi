﻿using HayvanBarinagi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Hayvan> Hayvanlar { get; set; }
    public DbSet<Kullanici> Kullanicilar { get; set; }
    
}
