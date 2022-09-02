using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingPractice.WinForm.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        protected ExceptionBase(string message)
            : base(message)
        {
        }

        public abstract ExceptionKind ExceptionKind { get; }
    }

    public enum ExceptionKind
    {
        Info,
        Warning,
        Error,
    }
}
