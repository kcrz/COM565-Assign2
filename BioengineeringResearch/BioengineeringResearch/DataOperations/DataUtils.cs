using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BioengineeringResearch.DataOperations
{
    class DataUtils
    {

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
    }
}
