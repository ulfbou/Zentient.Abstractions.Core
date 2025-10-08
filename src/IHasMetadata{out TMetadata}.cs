// <copyright file="IHasMetadata{out TMetadata}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Defines a contract for a metadata-carrying entity, parameterized by the metadata type.
    /// This bridge allows higher-level packages (e.g., Zentient.Metadata.Abstractions)
    /// to extend Core without circular dependencies.
    /// </summary>
    /// <typeparam name="TMetadata">The metadata type.</typeparam>
    public interface IHasMetadata<out TMetadata> : IHasMetadata where TMetadata : notnull
    {
        /// <summary>
        /// Gets the metadata associated with this entity.
        /// </summary>
        TMetadata Metadata { get; }
    }
}
