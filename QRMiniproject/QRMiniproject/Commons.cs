using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRMiniproject
{
   public static class Commons
    {
        /*
        //개인DB
        public static string ConnString = "Data Source=127.0.0.1; " + 
                                          "Initial Catalog=QR_ProjectDB; " +
                                          "Persist Security Info=True; " +
                                          "User ID=sa; " +
                                          "Password=p@ssw0rd!";
        */

        //공용DB
        public static string ConnString = "Data Source=192.168.0.63; " +
                                          "Initial Catalog=QR_ProjectDB; " +
                                          "Persist Security Info=True; " +
                                          "User ID=sa; " +
                                          "Password=p@ssw0rd!";


        public static string LoginUserid = "";
    }
}
