using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    [Serializable]
    public class DuplicateException : Exception
    {
        public string DuplicateTitle { get; }

        public DuplicateException() { }

        public DuplicateException(string message)
            : base(message) { }

        public DuplicateException(string message, Exception inner)
            : base(message, inner) { }

        public DuplicateException(string message, string DuplicateTitle)
            : this(message)
        {
            this.DuplicateTitle = DuplicateTitle;
        }
    }
}
