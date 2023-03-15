using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    [Serializable]
    public class NotOwnedException : Exception
    {
        public string DuplicateTitle { get; }

        public NotOwnedException() { }

        public NotOwnedException(string message)
            : base(message) { }

        public NotOwnedException(string message, Exception inner)
            : base(message, inner) { }

        public NotOwnedException(string message, string DuplicateTitle)
            : this(message)
        {
            this.DuplicateTitle = DuplicateTitle;
        }
    }
}
