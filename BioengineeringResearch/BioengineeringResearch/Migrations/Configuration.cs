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
            DateTime authorizedUntilDate = new DateTime(2015, 06, 30, 0, 0, 0);
            context.Employees.AddOrUpdate(i => i.EmployeeId,
                new Employee
                {
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
                    MinimumLevelReq = 4,
                    DoorName = "TestDoor"
                }

                );
            context.Visitors.AddOrUpdate(i => i.VisitorId,
                new Visitor {
                    FirstName = "Kaiyang",
                    LastName = "Zhou",
                    PIN = 1234,
                    AccessLevel = 3,
                    AuthorizedUntilDate = authorizedUntilDate,
                    Company = "VisitorCompany",
                    Phone = "028-23456789",
                    Email = "visitor@email.visitor.com"
                }

                );
            DateTime dateTimeStamp = new DateTime(2015, 03, 30, 0, 0, 0);
            context.AccessHistories.AddOrUpdate(i => i.HistoryId,
                new AccessHistory
                {
                    DoorId = "DR001",
                    EmployeeId = "EM001",
                    DateTimeStamp = dateTimeStamp
                },
                 new AccessHistory
                {
                    DoorId = "DR001",
                    EmployeeId = "VT001",
                    DateTimeStamp = dateTimeStamp
                }
                );
        }
    }
}
