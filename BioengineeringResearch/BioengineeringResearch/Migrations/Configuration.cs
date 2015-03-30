namespace BioengineeringResearch.Migrations
{
    using BioengineeringResearch.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BioengineeringResearch.Models.BioEngResearchSecurityContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BioengineeringResearch.Models.BioEngResearchSecurityContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            DateTime authorizedUntilDate = new DateTime(2015,06,30,0,0,0);
            context.Employees.AddOrUpdate(i => i.EmployeeId, 
                new Employee 
                {
                    EmployeeId = 1,
                    FirstName = "Kenneth",
                    LastName = "Cruz",
                    PIN = 1234,
                    AccessLevel = 4,                    
                    AuthorizedUntilDate = authorizedUntilDate,
                    Position = "Administrator",
                    Phone = "028-12345678",
                    Email = "admin@email.com"

                }
                );
            context.DoorTerminals.AddOrUpdate(i => i.DoorId,
                new DoorTerminal
                {
                    DoorId = 1,
                    MinimumLevelReq = 4
                }

                );
            DateTime dateTimeStamp = new DateTime(2015,03,30,0,0,0);
            context.AccessHistories.AddOrUpdate(i => i.HistoryId,
                new AccessHistory
                {
                    HistoryId = 1,
                    DoorId = 1,
                    EmployeeId = 1,
                    DateTimeStamp = dateTimeStamp
                }
                );
        }
    }
}
