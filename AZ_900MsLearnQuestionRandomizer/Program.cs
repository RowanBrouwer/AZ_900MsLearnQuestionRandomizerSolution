using AZ_900MsLearnQuestionRandomizerSolution.Data;
using AZ_900MsLearnQuestionRandomizerSolution.Data.Logic;
using AZ_900MsLearnQuestionRandomizerSolution.Data.QuizLogic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace AZ_900MsLearnQuestionRandomizer
{
    class Program
    {
        private ApplicationDbContext _context;
        static void Main(string[] args)
        {
             new Program().MainAsync().GetAwaiter().GetResult();
        }

        private async Task MainAsync()
        {
            using (var services = ConfigureServices())
            {
                _context = services.GetRequiredService<ApplicationDbContext>();
                ApplicationDbSeed.Seed(_context);

                var main = services.GetRequiredService<MainQuizMenu>();

                await main.MainLoop();
            }
        }

        private ServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                .AddDbContext<ApplicationDbContext>(options => 
                options.UseInMemoryDatabase("Server=(localdb)\\mssqllocaldb; Database=MsLearn_InMem; Trusted_Connection=True; MultipleActiveResultSets=true"))
                .AddScoped<IAwnserLogic, AwnserLogic>()
                .AddSingleton<MainQuizMenu>()
                .BuildServiceProvider();
        }
    }
}
