// <copyright file="DeprecatedInAttribute.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Attributes
{
    using System;

    /// <summary>
    /// Indicates that a concept was deprecated in a particular version and optionally suggests a replacement.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class DeprecatedInAttribute : Attribute
    {
        /// <summary>
        /// The version in which the concept was deprecated.
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Optional replacement identifier or guidance.
        /// </summary>
        public string? ReplacedBy { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedInAttribute"/> class.
        /// </summary>
        /// <param name="version">The version in which the concept was deprecated.</param>
        /// <param name="replacedBy">An optional replacement identifier or guidance.</param>
        public DeprecatedInAttribute(string version, string? replacedBy = null)
        {
            ArgumentException.ThrowIfNullOrEmpty(version, nameof(version));
            Version = version;
            ReplacedBy = replacedBy;
        }
    }
}