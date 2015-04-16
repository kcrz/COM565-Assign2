using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BioengineeringResearch.Models;

namespace BioengineeringResearch.DataOperations
{
    class DataOps
    {
        
        
        /// <summary>
        /// Returns Employee details using the id parameter
        /// Returns null if id is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Employee searchEmployeeDbById(String id)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                
                if (id.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                {
                    var query = from em in db.Employees where em.EmployeeId == id select em;
                    Employee[] employee = query.ToArray();
                    if (employee != null || employee.Length != 0)
                    {
                        return employee[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Returns Visitor Details using the id parameter.
        /// Returns null if Id is not found in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Visitor searchVisitorDbById(String id)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                if (id.ToUpper().StartsWith(DataStrings.VISITOR_TAG))
                {
                    var query = from vt in db.Visitors where vt.VisitorId == id select vt;
                    Visitor[] visitor = query.ToArray();
                    if (visitor != null || visitor.Length != 0)
                    {
                        return visitor[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<Visitor> searchVisitorByLastName(String lastName)
        {
            List<Visitor> visitorList = new List<Visitor>();
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from vt in db.Visitors where vt.LastName == lastName select vt;
                foreach(Visitor vt in query)
                {
                    visitorList.Add(vt);
                }
                return visitorList;
            }
        }

        public static List<Visitor> searchVisitorByFirstName(String firstName)
        {
            List<Visitor> visitorList = new List<Visitor>();
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from vt in db.Visitors where vt.FirstName == firstName select vt;
                foreach (Visitor vt in query)
                {
                    visitorList.Add(vt);
                }
                return visitorList;
            }
        }

        public static List<Employee> searchEmployeeByLastName(String lastName)
        {
            List<Employee> employeeList = new List<Employee>();
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from em in db.Employees where em.LastName == lastName select em;
                foreach (Employee em in query)
                {
                    employeeList.Add(em);
                }
                return employeeList;
            }
        }

        public static List<Employee> searchEmployeeByFirstName(String firstName)
        {
            List<Employee> employeeList = new List<Employee>();
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from em in db.Employees where em.FirstName == firstName select em;
                foreach (Employee em in query)
                {
                    employeeList.Add(em);
                }
                return employeeList;
            }
        }

        /// <summary>
        /// Checks Login credentials. Returns true if credentials are valid, otherwise false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static bool checkLogin(String id, String pin)
        {
            int pinInt;
            bool pinCheck = int.TryParse(pin, out pinInt);

            if (pinCheck)
            {
                using (var db = new BioEngResearchSecurityContext())
                {
                    if (id.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                    {
                        var query = from em in db.Employees where em.EmployeeId == id && em.PIN == pinInt select em;
                        Employee[] empl = query.ToArray();
                        if (empl == null || empl.Length == 0)
                        {
                            //credentials not found
                            return false;
                        }
                        else
                        {
                            //credentials found
                            return true;
                        }
                    }
                    //Visitor
                    else if (id.ToUpper().StartsWith(DataStrings.VISITOR_TAG))
                    {
                        var query = from vt in db.Visitors where vt.VisitorId == id && vt.PIN == pinInt select vt;
                        Visitor[] visitor = query.ToArray();
                        if (visitor == null || visitor.Length == 0)
                        {
                            //credentials not found
                            return false;
                        }
                        else
                        {
                            //credentials found
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                //non numeric pin
                return false;
            }


        }

        /// <summary>
        /// Adds Employee entity to the database
        /// returns true if successful otherwise false
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static bool addEmployee(Employee employee)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                try
                {
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Adds Visitor entity to the databse
        /// returns true if successful otherwise false
        /// </summary>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public static bool addVisitor(Visitor visitor)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                try
                {
                    db.Visitors.Add(visitor);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static void searchDoor()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
            }
        }

        /// <summary>
        /// Updates the Employee ID with the new employee object.
        /// Returns true if operation is successful otherwise false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="emp"></param>
        /// <returns></returns>
        public static bool update(String id, Employee emp)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from em in db.Employees where em.EmployeeId == id select em;
                Employee[] employee = query.ToArray();
                if (employee != null || employee.Length != 0)
                {
                    employee[0] = emp;
                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Updates Visistor ID with new Visitor object.
        /// Returns true if operation is successful otherwise false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="visitor"></param>
        /// <returns></returns>
        public static bool update(String id, Visitor visitor)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from vt in db.Visitors where vt.VisitorId == id select vt;
                Visitor[] visistorList = query.ToArray();
                if (visistorList != null || visistorList.Length != 0)
                {
                    visistorList[0] = visitor;
                    try
                    {
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Returns the position of the employee using the employee id
        /// Will return null if id is not an employee 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static String getEmployeePosition(String id)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                //Check if the ID is an employee
                if (id.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                {
                    var employeePosition = from em in db.Employees where em.EmployeeId == id select em.Position;
                    String[] positionList = employeePosition.ToArray();
                    if (positionList != null || positionList.Length != 0)
                    {
                        return positionList[0];
                    }
                    else
                    {
                        return null;
                    }
                }

                return null;
                
                
            }
        }

        /// <summary>
        /// Returns true if new access entry is success otherwise false
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="doorId"></param>
        /// <returns></returns>
        public static bool createNewAccessHistoryEntry(String userId, String doorId)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                DateTime accessDate = DateTime.UtcNow;
                if (userId.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                {
                    AccessHistory newEntry = new AccessHistory { DoorId = doorId, EmployeeId = userId, DateTimeStamp = accessDate};
                    db.AccessHistories.Add(newEntry);
                    db.SaveChanges();
                    return true;

                }
                else if (userId.ToUpper().StartsWith(DataStrings.VISITOR_TAG))
                {
                    AccessHistory newEntry = new AccessHistory { DoorId = doorId, VisitorId = userId, DateTimeStamp = accessDate };
                    db.AccessHistories.Add(newEntry);
                    db.SaveChanges();
                    return true;
                }
                else {
                    //invalid id
                    return false;
                }
            }
        }
    }


}
