// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// CallingConventions is a set of Bits representing the calling conventions in the system.

namespace System.Reflection
{
    [Flags]
    public enum CallingConventions
    {
        // Keep in sync with COMMember.cpp.
        Standard = 0x0001,
        VarArgs = 0x0002,
        Any = Standard | VarArgs,
        HasThis = 0x0020,
        ExplicitThis = 0x0040,
    }
}
