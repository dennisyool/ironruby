﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * ironruby@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using Microsoft.Scripting.Runtime;
using Microsoft.Scripting.Math;
using IronRuby.Runtime;
using Microsoft.Scripting.Generation;

namespace IronRuby.Builtins {
    /// <summary>
    /// Implements operations on multi-dimensional CLR array.
    /// TODO: implement all IList methods that don't work on multi-dim arrays.
    /// </summary>
    [RubyModule("MultiDimensionalArray", DefineIn = typeof(IronRubyOps.ClrOps), Extends = typeof(MultiDimensionalArray), Restrictions = ModuleRestrictions.None)]
    public static class MultiDimensionalArrayOps {
        // [], []= methods are mapped to Get/Set methods
    }
}
