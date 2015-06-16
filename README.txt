------------------------------------------------------------------
REQUIREMENTS
------------------------------------------------------------------
Visual Studio 2013 / 2012
NuGet Package Manager for Visual Studio 2013
Entity Framework Power Tools Beta 4
------------------------------------------------------------------
HOW TO VIEW SOURCE CODE
------------------------------------------------------------------
Extract BioengineeringResearch_Source_code.zip
Open BioengineeringResearch.sln using Visual Studio
If there are build errors make sure Entity Framework Power Tools Beta 4 is installed.
------------------------------------------------------------------
TESTING NOTES
------------------------------------------------------------------
The project uses entity framework for the database connections.

When testing Add Person functionality using VS2013
The data is inserted on a separate database located in

/bin/Debug
OR
/bin/Release

------------------------------------------------------------------
PROTOTYPE NOTES
------------------------------------------------------------------
1. Extract BioEngResearch_Prototype.zip
2. Run BioengineeringResearch.exe to start the application

Users:
Admin: ID = EM001, Password = 1234
Receptionist: ID = EM003, Password = 1234

Users in database
Employees
EM001 - Access Level 4
EM002 - Access Level 2 
EM003 - Access Level 1
EM004 - Access Level 3
EM005 - Access Level 3

Visitors
VT001 - Access Level 4
VT002 - Access Level 3
VT003 - Access Level 2
VT004 - Access Level 1