// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//
/*=============================================================================
**
**
**
** Purpose: Enum to represent the different threading models
**
**
=============================================================================*/

namespace System.Threading {

    [Serializable]
[System.Runtime.InteropServices.ComVisible(true)]
    public enum ApartmentState
    {   
        /*=========================================================================
        ** Constants for thread apartment states.
        =========================================================================*/
        STA = 0,
        MTA = 1,
        Unknown = 2
    }
}
