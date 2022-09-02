using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabindingPractice.WinForm.Exceptions
{
    public sealed class WarningException : ExceptionBase
    {
        public WarningException(string message)
            : base(message)
        {
        }

        public override ExceptionKind ExceptionKind => ExceptionKind.Warning;
    }
}
