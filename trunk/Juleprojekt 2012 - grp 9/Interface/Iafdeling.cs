using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Søren Rasmussen
namespace Interface
{
    public interface IAfdeling
    {
        int DepartmentID { get; }
        string DepartmentName { get; }
        string DepartmentNumber { get; }
        string StreetName { get; }
        int StreetNumber { get; }
        int PostalCode { get; }
    }
}
