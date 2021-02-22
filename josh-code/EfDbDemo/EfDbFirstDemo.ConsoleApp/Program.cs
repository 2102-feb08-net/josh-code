using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EfDbFirstDemo.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EfDbFirstDemo.ConsoleApp
{
    class Program
    {
        // Entity Framework Core
        // database-first approach steps...
        /*
         * 1. have a data access library project separate from the startup application project.
         *    (with a project reference from the latter to the former).
         *    have both target .NET 5.
         * 2. install Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.SqlServer
         *    to both projects.
         * 3. using Git Bash / terminal, from the data access project folder run (split into several lines for clarity):
         *    dotnet ef dbcontext scaffold <connection-string-in-quotes>
         *      Microsoft.EntityFrameworkCore.SqlServer
         *      --startup-project EfDbDemo.ConsoleApp
         *      --force
         *      --no-onconfiguring
         *    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold
         *    (if you don't have dotnet ef installed, run: "dotnet tool install --global dotnet-ef")
         *    (this will fail if your projects do not compile)
         * 4. any time you change the structure of the tables (DDL), go to step 3.
         */
        static void Main(string[] args)
        {
            // What we just did is called "reverse engineering"
            // Overall goal is: to have C# code that can represent the DB structure
            //      and interact with it
            // That code is called the EF model
            //      -a class derived from DbContext

            string connectionString = File.ReadAllText("~/Revature");
            DbContextOptions<ChinookContext> options = new DbContextOptionsBuilder<ChinookContext>()
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, minimumLevel: LogLevel.Information)
                .Options;
            using var context = new ChinookContext();

            // "LINQ to Objects", where IEnumerable version of LINQ is used
            var list = new List<Artist>() { null };
            list.First();

            // "LINQ to SQL" is a version of LINQ that uses IQueryable
            // Enforces logic of LINQ to translate and execute in SQL Server instead of in .NET
            var anArtist = context.Artists.First(x => x.Name.Contains("sabbath"));

            // Exercise: Methods to complete, or CRUD operations similar to given
            //      operations
            // Bonus: Involve Multiple Tables in Operations
            // Bonus: Base operations on user input

            // Display5Tracks()

            // EditOneOfThoseTracks()

            // Display5Tracks()

            // InsertANewTrack()

            // Display5Tracks()

            // DeleteTheNewTrack

            // Display5Tracks()
        }
    }
}
