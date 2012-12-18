using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using Model;
using Interface;
using System.Runtime.Serialization.Formatters.Binary;

//Søren Rasmussen
namespace Controller
{
    [Serializable]
    public class SystemController
    {
        // attributter
        private const string FILNAVN = "c:/data.bin"; // filen hvor data bliver gemt
        
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
            GemData();
           
        }

        // metode til at hente og returnere IEnumerator med samtlige afdelinger
        public IEnumerator GetDepartmentList()
        {
           return afdelingsColl.GetDepartmentList();
        }

        private void GemData()
        {
            FileStream fileStream = new FileStream(FILNAVN, FileMode.Create, FileAccess.Write); // Skaber fil til skrivning
            BinaryFormatter binFormatter = new BinaryFormatter(); // skab binary-formatter til objekt-serialisering

            // Serialiser system-controller til filestream
            binFormatter.Serialize(fileStream, this);


            fileStream.Close();// lukker stream
        }
        public static SystemController HentData()
        {
            FileStream fileStream = null;

            try // tjekker om en fil kan læses
            {
                fileStream = new FileStream(FILNAVN, FileMode.Open, FileAccess.Read); //åbner fil KUN til læsning
            }
            catch (Exception) // fejl ved åbning af fil
            {
                fileStream.Close();
                throw; // kaster ecveption videre til GUI
            }
            //skab binary formatter til objekt serialisering
            BinaryFormatter binFormatter = new BinaryFormatter();

            // Deserialiser filestream til system-controlleren
            SystemController controller = (SystemController)binFormatter.Deserialize(fileStream);

            fileStream.Close(); // lukker stream

            return controller;

        }
    }
}
