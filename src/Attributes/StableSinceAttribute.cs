// <copyright file="StableSinceAttribute.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Attributes
{
    using System;

    /// <summary>
    /// Indicates the version in which a contract became stable and safe for public consumption.
    /// </summary>
    /// <remarks>
    /// Apply this attribute to public contracts that have reached a stability milestone. The attribute
    /// is informational and can be used by documentation tools and release notes generation.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class StableSinceAttribute : Attribute
    {
        /// <summary>
        /// The version tag indicating stability.
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StableSinceAttribute"/> class.
        /// </summary>
        /// <param name="version">Version in which the contract became stable.</param>
        public StableSinceAttribute(string version) => Version = version;
    }
}
