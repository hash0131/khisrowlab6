using Lab6.Data;
using Lab6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StudentDbContext context)
        {
            context.Database.Migrate();
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Students[]
            {
            new Students{FirstName="Carson",LastName="Alexander",Program="ICT"},
            new Students{FirstName="Meredith",LastName="Alonso",Program="ICT"},
            new Students{FirstName="Arturo",LastName="Anand",Program="ICT"},
            new Students{FirstName="Gytis",LastName="Barzdukas",Program="ICT"},
            };
            foreach (Students c in students)
            {
                context.Students.Add(c);
            }
            context.SaveChanges();
        }
    }

}
