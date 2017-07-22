using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace mvcTest.Models
{
    public static class DBinitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new BookContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookContext>>());
            context.Database.EnsureCreated();
        }
    }
}