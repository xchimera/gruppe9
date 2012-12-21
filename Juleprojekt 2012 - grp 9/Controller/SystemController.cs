using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using Model;
using Interface;
using System.Runtime.Serialization.Formatters.Binary;

//Søren Rasmussen Start
namespace Controller
{
    [Serializable]
    public class SystemController
    {
        // attributter
        private const string FILNAVN = "c:/data.bin"; // filen hvor data bliver gemt
        
        private AfdelingsCollection afdelingsColl;
        private SporgsmaalCollection questionColl;

        // konstruktør
        public SystemController()
        {
            this.afdelingsColl = new AfdelingsCollection();
            this.questionColl = new SporgsmaalCollection();
        }

       
        public void CreateDepartment(string departmentNumber, string name, string streetName, int streetNumber, int postalCode)
        {
            Afdeling afdeling = afdelingsColl.OpretAfdeling(name, departmentNumber, streetName, streetNumber, postalCode);
            //Gemmer data i fil via en metode
            GemData();
           
        }

        // metode til at hente og returnere IEnumerator med samtlige afdelinger
        public IEnumerator GetDepartmentList()
        {
           return afdelingsColl.GetDepartmentList();
        }
        
        //metode til at gemme data i fil
        private void GemData()
        {
            FileStream fileStream = new FileStream(FILNAVN, FileMode.Create, FileAccess.Write); // Skaber fil til skrivning
            BinaryFormatter binFormatter = new BinaryFormatter(); // skab binary-formatter til objekt-serialisering

            // Serialiser system-controller til filestream
            binFormatter.Serialize(fileStream, this);


            fileStream.Close();// lukker stream
        }

        //Metode til at hente data
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
        // Søren Rasmussen Slut
        //Rasmus Start
        
        
        public void CreateQuestion(string text, string type)
        {
            Question question = questionColl.OpretSporgsmaal(text, type);
            //Gemmer data i fil via en metode
            GemData();
        }

        
        public IEnumerator GetQuestionList()
        {
            return questionColl.GetQuestionList();
        }

        




        // Rasmus Slut
    }
}
