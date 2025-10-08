// <copyright file="IAsyncRegistry{in TKey, TValue}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Registries
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Zentient.Core;

    /// <summary>
    /// Optional asynchronous registry contract for registries that perform I/O or remote operations.
    /// </summary>
    /// <remarks>
    /// Use this interface only for registries that need to perform asynchronous work (database calls,
    /// network requests, or other I/O) as part of registration or lookup. For purely in-memory or
    /// CPU-bound registries prefer <see cref="IRegistry{TValue}"/> which is intentionally small and
    /// synchronous for improved developer experience and testability.
    ///
    /// Guidance for third-party implementers:
    /// - Implement <see cref="IAsyncRegistry{TKey,TValue}"/> when your backing store is remote or when
    ///   registration/lookup may block on I/O. Keep the async surface minimal and document behavior.
    /// - If you expose both synchronous and asynchronous surfaces, document which methods may block and
    ///   prefer async-first implementations. Provide synchronous adapters in implementation packages
    ///   when necessary and clearly document their blocking behavior.
    /// - Avoid providing blocking implementations of async methods (i.e. do not call <c>.Result</c> or
    ///   <c>.GetAwaiter().GetResult()</c> inside your async implementations). If a blocking adapter is
    ///   required, provide it separately and warn consumers about potential deadlocks and thread-pool
    ///   starvation.
    /// </remarks>
    /// <typeparam name="TKey">Identifier type used by the registry. Must be non-nullable.</typeparam>
    /// <typeparam name="TValue">Concept type stored in the registry.</typeparam>
    public interface IAsyncRegistry<in TKey, TValue> : IRegistry<TKey, TValue>
        where TKey : notnull where TValue : IConcept
    {
        /// <summary>
        /// Registers the specified concept instance asynchronously.
        /// </summary>
        /// <param name="key">Key identifying the value.</param>
        /// <param name="value">Value to register.</param>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        ValueTask RegisterAsync(TKey key, TValue value, CancellationToken ct = default);

        /// <summary>
        /// Unregisters the specified concept instance asynchronously.
        /// </summary>
        /// <param name="key">Key identifying the value to remove.</param>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        /// <returns><see langword="true"/> if the item was removed; otherwise <see langword="false"/>.</returns>
        ValueTask<bool> UnregisterAsync(TKey key, CancellationToken ct = default);

        /// <summary>
        /// Asynchronously gets an item by identifier. Returns null when the identifier is not found.
        /// </summary>
        /// <param name="key">Key to lookup.</param>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        /// <returns>The value when found; otherwise <see langword="null"/>.</returns>
        ValueTask<TValue?> GetAsync(TKey key, CancellationToken ct = default);

        /// <summary>
        /// Asynchronously enumerates all registered items. Use when the backing store may be remote or streamed.
        /// </summary>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        IAsyncEnumerable<TValue> GetAllAsync(CancellationToken ct = default);
    }
}
