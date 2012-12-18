using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using Interface;
using System.IO;
using System.Collections;

namespace Controller
{
    public class SystemController
    {
        // attributter
        private AfdelingsCollection afdelingsColl;

        // konstruktør
        public SystemController()
        {
            this.afdelingsColl = new AfdelingsCollection();
        }

        public void CreateDepartment(string departmentNumber, string name, string streetName, int streetNumber, int postalCode)
        {
            Afdeling afdeling = afdelingsColl.OpretAfdeling(name, departmentNumber, streetName, streetNumber, postalCode);
            //Her skal der skrives noget kode som skriver til en tekst fil.
            
        }

        // metode til at hente og returnere IEnumerator med samtlige afdelinger
        public IEnumerator GetDepartmentList()
        {
           return afdelingsColl.GetDepartmentList();
        }
    }
}
