using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dormitory.Domain.Exceptions
{
    public class NameStateException : Exception
    {
        public NameStateException(string message) : base(message)
        { }


        public override string Message
        {
            get
            {
                return "Model State Error: " + base.Message;
            }
        }
    }
}
