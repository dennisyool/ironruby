﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.Dynamic;
using Microsoft.Scripting;

namespace IronPython.Runtime.Exceptions {
    /// <summary>
    /// .NET exception thrown when a Python syntax error is related to incorrect indentation.
    /// </summary>
    [Serializable]
    class IndentationException : SyntaxErrorException {
        public IndentationException(string message) : base(message) { }

        public IndentationException(string message, SourceUnit sourceUnit, SourceSpan span, int errorCode, Severity severity)
            : base(message, sourceUnit, span, errorCode, severity) { }

    }
}
