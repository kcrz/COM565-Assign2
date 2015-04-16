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
                    if (employee != null && employee.Length != 0)
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
        /// Search Employee table by name
        /// set second param to true if searching by last name
        /// </summary>
        /// <param name="name">
        /// <returns></returns>
        public static List<Employee> searchEmployeeByName(String name, bool isLastName)
        {
            List<Employee> employeeList = new List<Employee>();
            using (var db = new BioEngResearchSecurityContext())
            {
                if (!isLastName)
                {
                    //search by First Name
                    var query = from em in db.Employees where em.FirstName == name select em;
                    foreach (Employee em in query)
                    {
                        employeeList.Add(em);
                    }
                    return employeeList;

                }
                else
                {
                    //search by Last Name
                    var query = from em in db.Employees where em.LastName == name select em;
                    foreach (Employee em in query)
                    {
                        employeeList.Add(em);
                    }
                    return employeeList;
                }


            }
        }

        public static List<Employee> getAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from em in db.Employees select em;
                foreach (Employee em in query)
                {
                    if (em != null)
                    { employeeList.Add(em); }
                }
                return employeeList;
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
                    if (visitor != null && visitor.Length != 0)
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

        /// <summary>
        /// Search Visitor table by name
        /// set second param to true if searching by last name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isLastName"></param>
        /// <returns></returns>
        public static List<Visitor> searchVisitorByName(String name, bool isLastName)
        {
            List<Visitor> visitorList = new List<Visitor>();
            using (var db = new BioEngResearchSecurityContext())
            {
                if (!isLastName)
                {
                    //search by first name

                    var query = from vt in db.Visitors where vt.FirstName == name select vt;
                    foreach (Visitor vt in query)
                    {
                        visitorList.Add(vt);
                    }
                    return visitorList;
                }
                else
                {
                    //search by last name
                    var query = from vt in db.Visitors where vt.LastName == name select vt;
                    foreach (Visitor vt in query)
                    {
                        visitorList.Add(vt);
                    }
                    return visitorList;
                }
            }
        }

        public static List<Visitor> getAllVisitors()
        {
            List<Visitor> visitorList = new List<Visitor>();
            using (var db = new BioEngResearchSecurityContext())
            {
                var query = from vt in db.Visitors select vt;
                foreach (Visitor vt in query)
                {
                    if (vt != null)
                    { visitorList.Add(vt); }
                }
                return visitorList;
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
                    AccessHistory newEntry = new AccessHistory { DoorId = doorId, EmployeeId = userId, DateTimeStamp = accessDate };
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
                else
                {
                    //invalid id
                    return false;
                }
            }
        }

        public static List<AccessHistory> searchAccessHistoryByDate(DateTime date)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<AccessHistory> historyList = new List<AccessHistory>();
                var query = from history in db.AccessHistories where history.DateTimeStamp == date select history;
                foreach (AccessHistory ht in query)
                {
                    historyList.Add(ht);
                }
                return historyList;
            }
        }

        public static List<AccessHistory> searchAccessHistoryByDoor(String doorName)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<AccessHistory> historyList = new List<AccessHistory>();

                //get the door id using door name
                var queryDoorId = from dr in db.DoorTerminals where dr.DoorName == doorName select dr.DoorId;
                String doorId = queryDoorId.ToArray().GetValue(0).ToString();
                if (doorId != null || doorId.Length != 0)
                {
                    var queryHistory = from ht in db.AccessHistories where ht.DoorId == doorId select ht;
                    foreach (AccessHistory ht in queryHistory)
                    {
                        historyList.Add(ht);
                    }
                }

                return historyList;
            }
        }

        public static List<AccessHistory> searchAccessHistoryByUserId(String userId)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<AccessHistory> historyList = new List<AccessHistory>();
                var queryHistory = from ht in db.AccessHistories where ht.EmployeeId == userId || ht.VisitorId == userId select ht;
                foreach (AccessHistory ht in queryHistory)
                {
                    historyList.Add(ht);
                }

                return historyList;
            }
        }

        public static List<AccessHistory> searchAccessHistory(DateTime date, String userId)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<AccessHistory> historyList = new List<AccessHistory>();
                var queryHistory = from ht in db.AccessHistories where (ht.EmployeeId == userId || ht.VisitorId == userId) && ht.DateTimeStamp == date select ht;
                foreach (AccessHistory ht in queryHistory)
                {
                    historyList.Add(ht);
                }

                return historyList;
            }
        }

        public static List<AccessHistory> searchAccessHistory(DateTime date, String userId, String doorName)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<AccessHistory> historyList = new List<AccessHistory>();

                //get the door id using door name
                var queryDoorId = from dr in db.DoorTerminals where dr.DoorName == doorName select dr.DoorId;
                String doorId = queryDoorId.ToArray().GetValue(0).ToString();
                if (doorId != null || doorId.Length != 0)
                {
                    var queryHistory = from ht in db.AccessHistories where (ht.EmployeeId == userId || ht.VisitorId == userId) && ht.DateTimeStamp == date && ht.DoorId == doorId select ht;
                    foreach (AccessHistory ht in queryHistory)
                    {
                        historyList.Add(ht);
                    }
                }

                return historyList;
            }
        }
    }


}
