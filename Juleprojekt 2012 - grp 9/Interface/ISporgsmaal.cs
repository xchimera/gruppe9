﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Interface
{
       public interface ISporgsmaal
        {
             int QuestionID { get; }
             string QuestionText { set; get; }
             string QuestionType { set; get; }
          
        }
}
