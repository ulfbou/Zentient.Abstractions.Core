// <copyright file="InternalOnlyAttribute.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Attributes
{
    using System;

    /// <summary>
    /// Marks a contract as internal-only and not intended for public consumption.
    /// </summary>
    /// <remarks>
    /// Use this attribute to flag APIs that are part of the internal framework surface and
    /// may change without notice. Such APIs should not be used by external consumers.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class InternalOnlyAttribute : Attribute { }
}
