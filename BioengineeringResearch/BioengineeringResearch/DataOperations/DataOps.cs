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

        public static void searchDb(String id)
        {
            
            using (var db = new BioEngResearchSecurityContext())
            {
                //check what table to search
                //Employee
                if (id.ToUpper().StartsWith("EM"))
                {
                    var query = from em in db.Employees where em.EmployeeId == id select em;
                }
                //Visitor
                else if (id.ToUpper().StartsWith("VT"))
                {
                    var query = from vt in db.Visitors where vt.VisitorId == id select vt;
                }
                //Door
                else if (id.ToUpper().StartsWith("DR"))
                {
                    var query = from dr in db.DoorTerminals where dr.DoorId == id select dr;
                }
                else 
                {
                    //default invalid id
                }
            }
        }

        public static void addEmployee()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
            }
        }

        public static void addVisitor()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
            }
        }

        public static void searchDoor()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
            }
        }

        public static void update()
        {
            using (var db = new BioEngResearchSecurityContext())
            {
            }
        }
    }


}
