using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BioengineeringResearch.DataOperations
{
    /// <summary>
    /// Dedicated class for utility methods
    /// Author: Kenneth Cruz
    /// 30 Apr 2015
    /// </summary>
    class DataUtils
    {

        /// <summary>
        /// Check if param is a valid id using regular expression
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool isUserIdValid(String userId)
        {
            //VT OR EM followed by 2 to 12 digits
            Regex regex = new Regex("(VT|EM)[0-9]{2,12}");
            Match match = regex.Match(userId);
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check if id is an employee
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool isUserIdEmployee(String userId)
        {
            if (userId.ToUpper().StartsWith(DataStrings.EMPLOYEE_TAG))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// check if id is a visitor
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static bool isUserIdVisitor(String userId)
        {
            if (userId.ToUpper().StartsWith(DataStrings.VISITOR_TAG))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
