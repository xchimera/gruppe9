using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interface;

namespace Model
{
    [Serializable]
    public class Question : ISporgsmaal
    {
        // attributter
        public int QuestionID { set; get; }
        public string QuestionText { set; get; }
        public string QuestionType { set; get; }
        static private int i = 0; 

         public Question(string _questionText, string _questionType)
        {
           this.QuestionID = i++;
           this.QuestionText = _questionText;
           this.QuestionType = _questionType;
        }

    }
}
