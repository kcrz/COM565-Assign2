DATABASE SETUP

Requirements:
NuGet Package Manager for Visual Studio 2013
Entity Framework Power Tools Beta 4

The project uses entity framework for the database connections.
It ONLY uses local database therefore it is mandatory to copy the following files to your local directory.

Files:
BioEngResearchSecurity.mdf
BioEngResearchSecurity_log.ldf

Path:
Win8
C:\Users\<user>

Once you have the database in your local directory you will have to connect Visual Studio to the local database

If you get errors about database context or entity when building the solution you will need to
add the system references to your project


IF YOU UPDATE YOUR LOCAL DATABASE REMEMBER TO COPY IT TO YOUR GIT HUB REPO SO EVERYONE WILL HAVE THE SAME COPY