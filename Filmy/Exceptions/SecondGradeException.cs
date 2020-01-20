using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Exceptions
{
    public class SecondGradeException : Exception
    {
        public SecondGradeException() : this("You can't rate the movie for a second time")
        {
        }

        public SecondGradeException(string message) : base(message)
        {
        }

        public SecondGradeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SecondGradeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string Message => base.Message;

        public override IDictionary Data => base.Data;

        public override string StackTrace => base.StackTrace;

        public override string HelpLink { get => base.HelpLink; set => base.HelpLink = value; }
        public override string Source { get => base.Source; set => base.Source = value; }

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
