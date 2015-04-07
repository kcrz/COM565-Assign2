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
        public static Employee searchEmployeeDb(String id)
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
        public static Visitor searchVisitorDb(String id)
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
    }


}
