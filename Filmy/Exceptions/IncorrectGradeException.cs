﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Exceptions
{
    class IncorrectGradeException : Exception
    {
        public IncorrectGradeException():this("Grade not avaiable.")
        {
        }

        public IncorrectGradeException(string message) : base(message)
        {
        }

        public IncorrectGradeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectGradeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
