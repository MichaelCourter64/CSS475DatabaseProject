using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporClient
{
    class UserInfo
    {
        static string currentUsername;
        public static string CurrentUsername { set { currentUsername = value; } get { return currentUsername; } }
    }
}
