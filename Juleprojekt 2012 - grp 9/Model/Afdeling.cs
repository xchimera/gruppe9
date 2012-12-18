using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;
//Søren Rasmussen
namespace Model
{
    [Serializable]
    public class Afdeling : IAfdeling
    {
        // attributter
        public int DepartmentID { set; get; }
        public string DepartmentName { set; get; }
        public string DepartmentNumber { set; get; }
        public string StreetName { set; get; }
        public int StreetNumber { set; get; }
        public int PostalCode { set; get; }


        static private int i = 0;

        // konstruktør
        public Afdeling(string _departmentName, string _departmentNumber, string _streetName, int _streetNumber, int _postalCode)
        {
           this.DepartmentID = i++;
            this.DepartmentName = _departmentName;
            this.DepartmentNumber = _departmentNumber;
            this.StreetName = _streetName;
            this.StreetNumber = _streetNumber;
            this.PostalCode = _postalCode;
        }
    }
}
