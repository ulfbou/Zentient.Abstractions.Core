// <copyright file="IRegistry{TKey, TValue}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Registries
{
    using System.Collections.Generic;
    using Zentient.Core;

    /// <summary>
    /// Generic registry for registering and discovering conceptual types.
    /// </summary>
    /// <typeparam name="TKey">Identifier type used by the registry. Must be non-nullable.</typeparam>
    /// <typeparam name="TValue">Concept type stored in the registry.</typeparam>
    /// <remarks>
    /// This minimal, synchronous registry contract is intended for in-process, CPU-bound
    /// registries. Prefer this interface for lightweight, fast registries. If your backing
    /// store is I/O bound, implement an async registry variant instead.
    ///
    /// Implementations SHOULD be thread-safe where concurrent access is expected and SHOULD
    /// document any ordering or snapshot semantics of <see cref="GetAll"/>.
    /// </remarks>
    public interface IRegistry<in TKey, TValue>
        where TKey : notnull
        where TValue : IConcept
    {
        /// <summary>
        /// Registers a new concept instance under the specified key.
        /// </summary>
        void Register(TKey key, TValue value);

        /// <summary>
        /// Removes the concept instance associated with the specified key.
        /// </summary>
        bool Unregister(TKey key);

        /// <summary>
        /// Attempts to retrieve a concept by its key.
        /// </summary>
        bool TryGet(TKey key, out TValue? value);

        /// <summary>
        /// Gets all registered concept instances.
        /// </summary>
        IEnumerable<TValue> GetAll();
    }
}