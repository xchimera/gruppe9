using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Model
{
    
    [Serializable]
    public class SporgsmaalCollection
    {

        // attributter
        private List<Question> sporgsmaalliste;

        // konstruktør
        public SporgsmaalCollection()
        {
            this.sporgsmaalliste = new List<Question>();
        }

        // metode til at skabe et afdelings-objekt
        public Question OpretSporgsmaal(string _questionText, string _questionType)
        {
            Question ny_question = new Question(_questionText, _questionType);
            sporgsmaalliste.Add(ny_question);

            return ny_question;
        }

    

        //Metode til at hente en liste af afdelinger
        public IEnumerator GetQuestionList()
        {
            return sporgsmaalliste.GetEnumerator();
        }
    }
}
