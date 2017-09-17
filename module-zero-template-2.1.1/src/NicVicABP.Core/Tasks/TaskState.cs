using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NicVicABP.Tasks
{
    public enum TaskState : byte
    {
        /// <summary>
        /// The task is active.
        /// </summary>
        Active = 1,

        /// <summary>
        /// The task is completed.
        /// </summary>
        Completed = 2
    }
}
