using AZ_900MsLearnQuestionRandomizerSolution.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizerSolution.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("Server=(localdb)\\mssqllocaldb; Database=MsLearn_InMem; Trusted_Connection=True; MultipleActiveResultSets=true");
            }
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Awnser> Awnsers { get; set; }

    }
}
