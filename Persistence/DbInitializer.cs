using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.CompetenceTypes.Any()) return;

        var types = new List<CompetenceType>
        {
            new CompetenceType
            {
                Name = "Универсальные",
                ShortName = "УК"
            },

            new CompetenceType
            {
                Name = "Общепрофессиональные",
                ShortName = "ОПК"
            },

            new CompetenceType
            {
                Name = "Профессиональные",
                ShortName = "ПК"
            }

        };

        context.CompetenceTypes.AddRange(types);
        await context.SaveChangesAsync(); 
    }
}
