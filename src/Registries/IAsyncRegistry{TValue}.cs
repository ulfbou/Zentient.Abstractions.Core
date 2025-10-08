// <copyright file="IAsyncRegistry{TValue}.cs" authors="Zentient Framework Team">
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
    /// Implement this interface when your registry needs to perform asynchronous operations (database
    /// lookups, network calls, or other I/O) during registration or retrieval. This interface is an
    /// opt-in extension to the synchronous <see cref="IRegistry{TValue}"/> contract; prefer the
    /// synchronous registry for in-memory, CPU-bound scenarios.
    ///
    /// Guidance for implementers:
    /// - Keep the async surface minimal and document behavior clearly.
    /// - Prefer <see cref="Task{TResult}"/> for most async methods; use <see cref="ValueTask{TResult}"/>
    ///   only for very hot, allocation-sensitive paths and document the constraints associated with
    ///   <see cref="ValueTask{TResult}"/> (e.g., do not call .Result on incomplete ValueTask instances).
    /// - Provide synchronous adapters in implementation packages only when necessary, and document any
    ///   blocking semantics to consumers. Avoid hiding blocking behavior behind ostensibly non-blocking APIs.
    /// </remarks>
    /// <typeparam name="TValue">Concept type stored in the registry.</typeparam>
    public interface IAsyncRegistry<TValue> : IRegistry<TValue> where TValue : IConcept
    {
        /// <summary>
        /// Registers the specified concept instance asynchronously.
        /// </summary>
        /// <param name="item">The value to register.</param>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        ValueTask RegisterAsync(TValue item, CancellationToken ct = default);

        /// <summary>
        /// Unregisters the specified concept instance asynchronously.
        /// </summary>
        /// <param name="item">The value to unregister.</param>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        /// <returns>True if the item was removed; otherwise false.</returns>
        ValueTask<bool> UnregisterAsync(TValue item, CancellationToken ct = default);

        /// <summary>
        /// Asynchronously gets an item by identifier. Returns null when the identifier is not found.
        /// </summary>
        /// <typeparam name="TId">Identifier type.</typeparam>
        /// <param name="id">Identifier to lookup.</param>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        /// <returns>The value when found; otherwise null.</returns>
        ValueTask<TValue?> GetAsync<TId>(TId id, CancellationToken ct = default) where TId : notnull;

        /// <summary>
        /// Asynchronously enumerates all registered items. Use when the backing store may be remote or streamed.
        /// </summary>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        IAsyncEnumerable<TValue> GetAllAsync(CancellationToken ct = default);
    }
}
