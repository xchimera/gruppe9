using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;

namespace Model
{
    public class Afdeling : Iafdeling
    {
        private int departmentID { get; }
        private string departmentName { set; get; }
        private string departmentNumber { set; get; }


        static private int i = 0;

        public Afdeling(string _departmentName)
        {
            
            int departmentID = i++;
            departmentName = _departmentName;
           
        }
    }
}
