using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uid_project
{
    internal class Global_data
    {
        private static string name = null;
        public static string username
        {
            get { return name; }
            set { name = value; }
        }
        private static int id;
        public static int userid
        {
            get { return id; }  
            set { id = value; }
        }
        private static int c_id;
        public static int categories_id
        {
            get { return c_id; }
            set { c_id = value; }
        }
        private static int q_id;

        public static int question_id
        {
            get { return q_id; }
            set { q_id = value; }
        }
        private static string search=null;
        public static string search_text
        {
            get { return search; }  
            set { search = value; }
        }
    }
}
