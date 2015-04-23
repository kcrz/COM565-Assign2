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
        /// <summary>
        /// Returns all employee info
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Returns all visitor info
        /// </summary>
        /// <returns></returns>
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
                    employee[0].FirstName = emp.FirstName;
                    employee[0].LastName = emp.LastName;
                    employee[0].PIN = emp.PIN;
                    employee[0].AccessLevel = emp.AccessLevel;
                    employee[0].AuthorizedUntilDate = emp.AuthorizedUntilDate;
                    employee[0].Position = emp.Position;
                    employee[0].Department = emp.Department;
                    employee[0].Company = emp.Company;
                    employee[0].Phone = emp.Phone;
                    employee[0].Email = emp.Email;
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
                    visistorList[0].FirstName = visitor.FirstName;
                    visistorList[0].LastName = visitor.LastName;
                    visistorList[0].PIN = visitor.PIN;
                    visistorList[0].AccessLevel = visitor.AccessLevel;
                    visistorList[0].AuthorizedUntilDate = visitor.AuthorizedUntilDate;
                    visistorList[0].Position = visitor.Position;
                    visistorList[0].Department = visitor.Department;
                    visistorList[0].Company = visitor.Company;
                    visistorList[0].Phone = visitor.Phone;
                    visistorList[0].Email = visitor.Email;
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
        public static bool createNewAccessHistoryEntry(String userId, String doorName)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                DateTime accessDate = DateTime.Today.Date;
                TimeSpan accessFullTime = DateTime.Now.TimeOfDay;
                TimeSpan accessTime = new TimeSpan(accessFullTime.Hours, accessFullTime.Minutes, accessFullTime.Seconds);
                if (userId.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                {
                    //get the door id using door name
                    var queryDoorId = from dr in db.DoorTerminals where dr.DoorName == doorName select dr.DoorId;
                    string[] doorArray = queryDoorId.ToArray();
                    if (doorArray != null && doorArray.Length != 0)
                    {
                        String doorId = doorArray.GetValue(0).ToString();
                        if (doorId != null && doorId.Length != 0)
                        {
                            AccessHistory newEntry = new AccessHistory { DoorId = doorId, EmployeeId = userId.ToUpper(), DateStamp = accessDate, TimeStamp = accessTime };
                            db.AccessHistories.Add(newEntry);
                            db.SaveChanges();
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }
                }
                else if (userId.ToUpper().StartsWith(DataStrings.VISITOR_TAG))
                {
                    //get the door id using door name
                    var queryDoorId = from dr in db.DoorTerminals where dr.DoorName == doorName select dr.DoorId;
                    string[] doorArray = queryDoorId.ToArray();
                    if (doorArray != null && doorArray.Length != 0)
                    {
                        String doorId = doorArray.GetValue(0).ToString();
                        if (doorId != null && doorId.Length != 0)
                        {
                            AccessHistory newEntry = new AccessHistory { DoorId = doorId, VisitorId = userId.ToUpper(), DateStamp = accessDate, TimeStamp = accessTime };
                            db.AccessHistories.Add(newEntry);
                            db.SaveChanges();
                            return true;
                        }
                        else { return false; }
                    }
                    else { return false; }

                }
                else
                {
                    //invalid id
                    return false;
                }
            }
        }

        /// <summary>
        /// Returns a list of Access History
        /// Uses date parameter to search database
        /// boolean to determine which table to search (Employee or Visitor)
        /// </summary>
        /// <param name="date"></param>
        /// <param name="isEmployee"></param>
        /// <returns></returns>
        public static List<DisplayedHistory> searchAccessHistoryByDate(DateTime date, bool isEmployee)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                if (isEmployee)
                {
                    List<DisplayedHistory> historyList = new List<DisplayedHistory>();
                    var query = from ht in db.AccessHistories
                                from dr in db.DoorTerminals
                                from em in db.Employees
                                where ht.DoorId == dr.DoorId
                                && ht.DateStamp == date
                                && ht.EmployeeId == em.EmployeeId
                                join tbl in db.AccessHistories on ht.DateStamp equals tbl.DateStamp
                                where tbl.DateStamp == date
                                && ht.TimeStamp == tbl.TimeStamp
                                select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, EmployeeId = tbl.EmployeeId, FirstName = em.FirstName, LastName = em.LastName, AccessLevel = em.AccessLevel };
                    foreach (DisplayedHistory ht in query)
                    {
                        if (ht != null)
                        {
                            historyList.Add(ht);
                        }
                    }
                    return historyList;

                }
                else
                {
                    List<DisplayedHistory> historyList = new List<DisplayedHistory>();
                    var query = from ht in db.AccessHistories
                                from dr in db.DoorTerminals
                                from vt in db.Visitors
                                where ht.DoorId == dr.DoorId
                                && ht.DateStamp == date
                                && ht.VisitorId == vt.VisitorId
                                join tbl in db.AccessHistories on ht.DateStamp equals tbl.DateStamp
                                where tbl.DateStamp == date
                                && ht.TimeStamp == tbl.TimeStamp
                                select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, VisitorId = tbl.VisitorId, FirstName = vt.FirstName, LastName = vt.LastName, AccessLevel = vt.AccessLevel };
                    foreach (DisplayedHistory ht in query)
                    {
                        if (ht != null)
                        {
                            historyList.Add(ht);
                        }
                    }
                    return historyList;
                }
            }
        }
        /// <summary>
        /// Returns a list of Access History
        /// Uses Door parameter to search database
        /// boolean to determine which table to search (Employee or Visitor)
        /// </summary>
        /// <param name="doorName"></param>
        /// <param name="isEmployee"></param>
        /// <returns></returns>
        public static List<DisplayedHistory> searchAccessHistoryByDoor(String doorName, bool isEmployee)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<DisplayedHistory> historyList = new List<DisplayedHistory>();
                if (isEmployee)
                {
                    //get the door id using door name
                    var queryDoorId = from dr in db.DoorTerminals where dr.DoorName == doorName select dr.DoorId;
                    string[] doorArray = queryDoorId.ToArray();
                    if (doorArray != null && doorArray.Length != 0)
                    {
                        String doorId = doorArray.GetValue(0).ToString();
                        if (doorId != null && doorId.Length != 0)
                        {
                            var query = from ht in db.AccessHistories
                                        from dr in db.DoorTerminals
                                        from em in db.Employees
                                        where ht.DoorId == doorId
                                        && dr.DoorId == doorId
                                        && ht.EmployeeId == em.EmployeeId
                                        join tbl in db.AccessHistories on ht.DoorId equals tbl.DoorId
                                        where tbl.DoorId == doorId
                                        && ht.EmployeeId == tbl.EmployeeId
                                        select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, EmployeeId = tbl.EmployeeId, FirstName = em.FirstName, LastName = em.LastName, AccessLevel = em.AccessLevel };
                            foreach (DisplayedHistory ht in query)
                            {
                                if (ht != null)
                                {
                                    historyList.Add(ht);
                                }
                            }
                        }
                    }
                    return historyList;
                }
                else
                {
                    var queryDoorId = from dr in db.DoorTerminals where dr.DoorName == doorName select dr.DoorId;
                    string[] doorArray = queryDoorId.ToArray();
                    if (doorArray != null && doorArray.Length != 0)
                    {
                        String doorId = doorArray.GetValue(0).ToString();
                        if (doorId != null && doorId.Length != 0)
                        {
                            var query = from ht in db.AccessHistories
                                        from dr in db.DoorTerminals
                                        from vt in db.Visitors
                                        where ht.DoorId == doorId
                                        && dr.DoorId == doorId
                                               && ht.VisitorId != null
                                               && ht.VisitorId == vt.VisitorId
                                        join tbl in db.AccessHistories on ht.VisitorId equals tbl.VisitorId
                                        select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, VisitorId = tbl.VisitorId, FirstName = vt.FirstName, LastName = vt.LastName, AccessLevel = vt.AccessLevel };
                            foreach (DisplayedHistory ht in query)
                            {
                                if (ht != null)
                                {
                                    historyList.Add(ht);
                                }
                            }
                        }
                    }
                    return historyList;
                }


            }
        }
        /// <summary>
        /// Returns a list of Access History
        /// Uses UserId parameter to search database
        /// boolean to determine which table to search (mployee or Visitor)
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<DisplayedHistory> searchAccessHistoryByUserId(String userId)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<DisplayedHistory> historyList = new List<DisplayedHistory>();

                //Employee
                if (userId.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
                {
                    var queryHistory = from ht in db.AccessHistories
                                       from dr in db.DoorTerminals
                                       from em in db.Employees
                                       where ht.EmployeeId == userId
                                       && em.EmployeeId == userId
                                       && ht.DoorId == dr.DoorId
                                       join tbl in db.AccessHistories on ht.EmployeeId equals tbl.EmployeeId
                                       where tbl.EmployeeId == userId
                                       && ht.DateStamp == tbl.DateStamp
                                       && ht.DoorId == tbl.DoorId
                                       select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, EmployeeId = tbl.EmployeeId, FirstName = em.FirstName, LastName = em.LastName, AccessLevel = em.AccessLevel };
                    foreach (DisplayedHistory ht in queryHistory)
                    {
                        if (ht != null)
                        {
                            historyList.Add(ht);
                        }
                    }

                    return historyList;
                }
                //Visitor
                else
                {
                    var queryHistory = from ht in db.AccessHistories
                                       from dr in db.DoorTerminals
                                       from vt in db.Visitors
                                       where ht.VisitorId == userId
                                       && vt.VisitorId == userId
                                       && ht.DoorId == dr.DoorId
                                       join tbl in db.AccessHistories on ht.VisitorId equals tbl.VisitorId
                                       where tbl.VisitorId == userId
                                       && ht.DateStamp == tbl.DateStamp
                                       && ht.DoorId == tbl.DoorId
                                       select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, VisitorId = tbl.VisitorId, FirstName = vt.FirstName, LastName = vt.LastName, AccessLevel = vt.AccessLevel };
                    foreach (DisplayedHistory ht in queryHistory)
                    {
                        if (ht != null)
                        {
                            historyList.Add(ht);
                        }
                    }

                    return historyList;
                }

            }
        }
        /// <summary>
        /// Returns a list of Access History
        /// Uses Time parameter to search database
        /// boolean to determine which table to search (mployee or Visitor)
        /// </summary>
        /// <param name="time"></param>
        /// <param name="isEmployee"></param>
        /// <returns></returns>
        public static List<DisplayedHistory> searchAccessHistoryByTime(TimeSpan time, bool isEmployee)
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<DisplayedHistory> historyList = new List<DisplayedHistory>();
                //Emplyee
                if (isEmployee)
                {
                    var queryHistory = from ht in db.AccessHistories
                                       from dr in db.DoorTerminals
                                       from em in db.Employees
                                       where ht.TimeStamp == time
                                       && ht.EmployeeId == em.EmployeeId
                                       && ht.DoorId == dr.DoorId
                                       join tbl in db.AccessHistories on ht.TimeStamp equals tbl.TimeStamp
                                       where tbl.TimeStamp == time
                                       select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, EmployeeId = tbl.EmployeeId, FirstName = em.FirstName, LastName = em.LastName, AccessLevel = em.AccessLevel };
                    foreach (DisplayedHistory ht in queryHistory)
                    {
                        if (ht != null)
                        {
                            historyList.Add(ht);
                        }
                    }

                    return historyList;
                }
                //Visitor
                else
                {
                    var queryHistory = from ht in db.AccessHistories
                                       from dr in db.DoorTerminals
                                       from vt in db.Visitors
                                       where ht.TimeStamp == time
                                       && ht.VisitorId == vt.VisitorId
                                       && ht.DoorId == dr.DoorId
                                       join tbl in db.AccessHistories on ht.VisitorId equals tbl.VisitorId
                                       where tbl.TimeStamp == time
                                       select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, VisitorId = tbl.VisitorId, FirstName = vt.FirstName, LastName = vt.LastName, AccessLevel = vt.AccessLevel };
                    foreach (DisplayedHistory ht in queryHistory)
                    {
                        if (ht != null)
                        {
                            historyList.Add(ht);
                        }
                    }

                    return historyList;
                }

            }
        }
        /// <summary>
        /// Returns all employee access history data
        /// </summary>
        /// <returns></returns>
        public static List<DisplayedHistory> getAllEmployeeAccessHistory()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<DisplayedHistory> hisList = new List<DisplayedHistory>();

                var query = from ht in db.AccessHistories
                            from dr in db.DoorTerminals
                            from em in db.Employees
                            where ht.DoorId == dr.DoorId
                            && ht.EmployeeId != null
                            && ht.EmployeeId == em.EmployeeId
                            join tbl in db.AccessHistories on ht.EmployeeId equals tbl.EmployeeId
                            where ht.EmployeeId == tbl.EmployeeId
                            && ht.DoorId == tbl.DoorId
                            select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, EmployeeId = tbl.EmployeeId, FirstName = em.FirstName, LastName = em.LastName, AccessLevel = em.AccessLevel };

                foreach (DisplayedHistory data in query)
                {
                    if (data != null)
                    {
                        hisList.Add(data);
                    }
                }

                return hisList;
            }
        }
        /// <summary>
        /// Returns all visitor access history
        /// </summary>
        /// <returns></returns>
        public static List<DisplayedHistory> getAllVisitorAccessHistory()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
                List<DisplayedHistory> hisList = new List<DisplayedHistory>();

                var query = from ht in db.AccessHistories
                            from dr in db.DoorTerminals
                            from vt in db.Visitors
                            where ht.DoorId == dr.DoorId
                            && ht.VisitorId != null
                            && ht.VisitorId == vt.VisitorId
                            join tbl in db.AccessHistories on ht.VisitorId equals tbl.VisitorId
                            where ht.VisitorId == tbl.VisitorId
                            && ht.DoorId == tbl.DoorId
                            select new DisplayedHistory { DateStamp = tbl.DateStamp, TimeStamp = tbl.TimeStamp, DoorName = dr.DoorName, VisitorId = tbl.VisitorId, FirstName = vt.FirstName, LastName = vt.LastName, AccessLevel = vt.AccessLevel };

                foreach (DisplayedHistory data in query)
                {
                    if (data != null)
                    {
                        hisList.Add(data);
                    }
                }

                return hisList;
            }
        }

        /// <summary>
        /// Returns true if user have enough clearance to open door otherwise it will return false
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="doorName"></param>
        /// <returns></returns>
        public static bool grantAccess(String userId, String doorName)
        {
            int userAccessLevel = 0;
            int doorAccessReqLevel = 0;

            using (var db = new BioEngResearchSecurityContext())
            {
                //Get door access level requirement
                var doorQuery = from dr in db.DoorTerminals
                                where dr.DoorName == doorName.ToUpper()
                                select dr.MinimumLevelReq;

                int[] doorAccessLevelArray = doorQuery.ToArray();
                if (doorAccessLevelArray != null && doorAccessLevelArray.Length != 0)
                {
                    doorAccessReqLevel = doorAccessLevelArray[0];
                }
                else
                {
                    //return false if door cant be found
                    return false;
                }


                //Get user access level
                if (DataUtils.isUserIdEmployee(userId))
                {
                    //Employee
                    var query = from em in db.Employees
                                where em.EmployeeId == userId.ToUpper()
                                select em.AccessLevel;
                    int[] accessLevelList = query.ToArray();
                    if (accessLevelList != null && accessLevelList.Length != 0)
                    {
                        //User access level successfuly retrieved
                        userAccessLevel = accessLevelList[0];
                    }
                    else
                    {
                        //return false if user cant be found
                        return false;
                    }
                }
                else
                { 
                    //Visitor
                    var query = from vt in db.Visitors
                                where vt.VisitorId == userId.ToUpper()
                                select vt.AccessLevel;
                    int[] accessLevelList = query.ToArray();
                    if (accessLevelList != null && accessLevelList.Length != 0)
                    {
                        //User access level successfuly retrieved
                        userAccessLevel = accessLevelList[0];
                    }
                    else
                    {
                        //return false if user cant be found
                        return false;
                    }
                }

                //evaluate user access level and door min access requirement
                if (userAccessLevel >= doorAccessReqLevel)
                {
                    //requirements met
                    return true;
                }
                else
                {
                    //failed
                    return false;
                }
            }

        }
    }


}
