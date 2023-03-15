using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    [Serializable]
    public class NotAvailableException : Exception
    {
        public string DuplicateTitle { get; }

        public NotAvailableException() { }

        public NotAvailableException(string message)
            : base(message) { }

        public NotAvailableException(string message, Exception inner)
            : base(message, inner) { }

        public NotAvailableException(string message, string DuplicateTitle)
            : this(message)
        {
            this.DuplicateTitle = DuplicateTitle;
        }
    }
}
