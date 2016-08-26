#if UNIX

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gio
{
    internal static partial class Interop
    {
        internal static class Libraries
        {
            internal const string Gio = @"libgio-2.0-0.so";
        }
    }
}

#endif