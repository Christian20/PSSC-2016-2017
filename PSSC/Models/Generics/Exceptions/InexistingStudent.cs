﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    public class InexistingStudent:Exception
    {
        public InexistingStudent(String message) : base(message)
        {
            
        }
    }
}
