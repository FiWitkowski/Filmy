using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Exceptions
{
    public class AdminAldeadyCreatedException : Exception
    {
        public AdminAldeadyCreatedException() : this("Administrator was already created. You cannot have more than one administrator.")
        {
        }

        public AdminAldeadyCreatedException(string message) : base(message)
        {
        }

        public AdminAldeadyCreatedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AdminAldeadyCreatedException(SerializationInfo info, StreamingContext context) : base(info, context)
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
