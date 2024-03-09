using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLab
{
    internal class Trap : Exception
    {
        public Trap(string? message) : base(message)
        {

        }
    }
}
