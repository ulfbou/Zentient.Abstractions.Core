// <copyright file="PublicContractAttribute.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Attributes
{
    using System;

    /// <summary>
    /// Marks a type as a public contract which is intended for consumption by external clients.
    /// </summary>
    /// <remarks>
    /// Use this attribute to signal that a type is part of the public API surface. It does not
    /// change visibility but is useful for API documentation generators and analyzers.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    public sealed class PublicContractAttribute : Attribute { }
}
