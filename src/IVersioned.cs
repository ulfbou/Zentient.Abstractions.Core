// <copyright file="IVersioned.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Represents a concept that carries a stable version identifier and deprecation metadata.
    /// </summary>
    /// <remarks>
    /// Implementations SHOULD use semantic version strings where possible (e.g. "1.2.0").
    /// The <see cref="IsDeprecated"/> flag indicates that the concept should not be used for new
    /// integrations; <see cref="DeprecatedIn"/> can provide the version in which deprecation occurred.
    /// </remarks>
    public interface IVersioned : IConcept
    {
        /// <summary>
        /// Gets the semantic version or version token for the concept.
        /// </summary>
        string Version { get; }
        /// <summary>
        /// Gets whether this concept is considered deprecated.
        /// </summary>
        bool IsDeprecated { get; }
        /// <summary>
        /// Optional hint indicating the version in which the concept became deprecated.
        /// </summary>
        string? DeprecatedIn { get; }
    }
}
