﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public class MovieRentalsDbContext : DbContext, IMovieRentalsDbContext
    {
        public MovieRentalsDbContext(DbContextOptions<MovieRentalsDbContext> options)
            : base(options) 
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
