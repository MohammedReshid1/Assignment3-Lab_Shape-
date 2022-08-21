using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentregistration
{
    internal class model
    {
        public static List<model> mo = new List<model>();
        public string id { get; set; }
        public string fname { get; set; }

        public string lname { get; set; }
        public string address { get; set; }
        public string schoolYear { get; set; }
        public string gender { get; set; }
        
        public void save()
        {
            Console.WriteLine("student saved");
            mo.Add(this);
        }

        public static List<model> getAll()
        {
           return mo ;
        }
    }
}
