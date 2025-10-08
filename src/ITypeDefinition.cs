// <copyright file="ITypeDefinition.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a type definition of a concept.
    /// Attributes MUST be stable identifiers suitable for schema and analyzer enforcement,
    /// not ad-hoc runtime metadata.
    /// </summary>
    /// <remarks>
    /// Type definitions are intended to be lightweight, discoverable descriptors of domain concepts.
    /// Implementations should expose stable identifiers, a human-friendly name, version information,
    /// and optional metadata. Prefer immutability for definition instances.
    /// </remarks>
    public interface ITypeDefinition : IDefinition, IIdentifiable<string>, INamed, IVersioned, IDescribed
    {
        /// <summary>
        /// Gets a read-only set of static attributes describing the concept type.
        /// Keys MUST be stable identifiers suitable for schema/enforcement.
        /// </summary>
        IReadOnlyDictionary<string, object?> Attributes { get; }
    }
}
