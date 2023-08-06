using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    internal class Global
    {
        private static string username = "";
        private static string password = "";
        private static bool logged = false;
        private static int randNum = -1;


        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        public static bool Logged
        {
            get { return logged; }
            set { logged = value; }
        }
        public static int RandNum
        {
            get { return randNum; }
            set { randNum = value; }
        }
    }
}
