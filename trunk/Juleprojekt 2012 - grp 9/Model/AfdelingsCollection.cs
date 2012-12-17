using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    public class AfdelingsCollection
    {
        // attribut
        private List<Afdeling> afdelingsliste;

        // konstruktør
        public AfdelingsCollection()
        {
            this.afdelingsliste = new List<Afdeling>();
        }

        // metode til at skabe et afdelings-objekt
        public Afdeling OpretAfdeling(string _departmentName, string _departmentNumber, string _streetName, int _streetNumber, int _postalCode)
        {
            Afdeling ny_afdeling = new Afdeling(_departmentName, _departmentNumber,_streetName,_streetNumber,_postalCode);
            afdelingsliste.Add(ny_afdeling);

            return ny_afdeling;
        }

        //Metode til at hente en liste af afdelinger
        public IEnumerator GetDepartmentList()
        {
            return afdelingsliste.GetEnumerator();
        }
    }
}
