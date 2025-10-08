// <copyright file="IRegistry{TValue}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Registries
{
    using System.Collections.Generic;
    using Zentient.Core;

    /// <summary>
    /// Synchronous registry abstraction for managing and discovering in-process concepts.
    /// </summary>
    /// <remarks>
    /// The registry contract is intentionally minimal and synchronous to prioritize developer
    /// experience (DX), testability, and predictable semantics for in-memory scenarios.
    ///
    /// Guidance for third-party implementers:
    /// - Implement this interface for lightweight, in-memory registries where operations are CPU-bound and fast.
    /// - If your registry is backed by I/O (database, remote service), implement <see cref="IAsyncRegistry{TValue}"/> instead
    ///   or provide it alongside this interface in an implementation package. Avoid blocking I/O on methods of this interface.
    /// - Implementations SHOULD return stable snapshots from <see cref="GetAll"/> (immutable or defensive copies)
    ///   to avoid consumers encountering concurrent modifications.
    ///
    /// See docs/specs/Zentient.Abstractions.vNext.md for migration guidance and adapter examples.
    /// </remarks>
    /// <typeparam name="TValue">Concept type stored in the registry.</typeparam>
    public interface IRegistry<TValue> where TValue : IConcept
    {
        /// <summary>
        /// Registers the specified concept instance.
        /// </summary>
        /// <param name="item">Concept instance to register.</param>
        void Register(TValue item);

        /// <summary>
        /// Unregisters the specified concept instance.
        /// </summary>
        /// <param name="item">Concept instance to unregister.</param>
        /// <returns>True if the item was removed; otherwise false.</returns>
        bool Unregister(TValue item);

        /// <summary>
        /// Attempts to retrieve a concept by identifier.
        /// </summary>
        /// <typeparam name="TId">Identifier type.</typeparam>
        /// <param name="id">Identifier to lookup.</param>
        /// <param name="item">When this method returns, contains the found item or null.</param>
        /// <returns>True if found; otherwise false.</returns>
        bool TryGet<TId>(TId id, out TValue? item) where TId : notnull;

        /// <summary>
        /// Gets a snapshot enumeration of all registered items.
        /// </summary>
        /// <remarks>Implementations SHOULD return a stable snapshot to avoid concurrent modification surprises.</remarks>
        IEnumerable<TValue> GetAll();
    }
}
