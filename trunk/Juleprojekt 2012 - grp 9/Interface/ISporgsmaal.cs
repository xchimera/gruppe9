using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interface
{
       public interface ISporgsmaal
        {
            public int QuestionID { set; get; }
            public string QuestionText { set; get; }
            public string QuestionType { set; get; }
            static private int i = 0;
        }
}
