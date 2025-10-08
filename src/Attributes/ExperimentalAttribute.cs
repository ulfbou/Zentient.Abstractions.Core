// <copyright file="ExperimentalAttribute.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Attributes
{
    using System;

    /// <summary>
    /// Marks a type as experimental and subject to change.
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class ExperimentalAttribute : Attribute { }
}