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


        public DuplicateException(string message, string DuplicateTitle)
            : base(message)
        {
            this.DuplicateTitle = DuplicateTitle;
        }
    }
}
