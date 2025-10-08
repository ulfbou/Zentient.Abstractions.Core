// <copyright file="IAsyncBuilder{out TBuilt}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Builders
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Optional asynchronous builder contract for constructing an instance of <typeparamref name="TBuilt"/>.
    /// </summary>
    /// <remarks>
    /// Implement this interface only when construction requires asynchronous operations such as I/O
    /// (network calls, database access, file I/O). The core library prioritizes a sync-first experience
    /// for lightweight, in-memory scenarios; async builders are an opt-in surface for implementation libraries
    /// that must perform non-blocking work.
    ///
    /// Guidance for implementers:
    /// - Prefer returning <see cref="Task{TResult}"/> when the operation is likely to allocate or when
    ///   callers will commonly await the result. Use <see cref="ValueTask{TResult}"/> only for very hot
    ///   paths where allocation avoidance is critical and callers understand ValueTask usage semantics.
    /// - Do not provide blocking wrappers (i.e. calling <c>.GetAwaiter().GetResult()</c>) inside your
    ///   implementations; if a synchronous adapter is required, provide it in a separate implementation
    ///   package and document the blocking behavior clearly.
    /// - Keep the async surface focused: avoid exposing unnecessary additional members on the async contract.
    ///
    /// Consumers who only need synchronous construction should implement the synchronous
    /// <see cref="IBuilder{TBuilt}"/> or provide a lightweight adapter that calls the async method in a
    /// documented, deliberate manner.
    /// </remarks>
    /// <typeparam name="TBuilt">Type produced by the builder.</typeparam>
    public interface IAsyncBuilder<TBuilt> : IBuilder<TBuilt> where TBuilt : notnull
    {
        /// <summary>
        /// Builds the final object asynchronously.
        /// </summary>
        /// <param name="ct">Cancellation token for cooperative cancellation.</param>
        /// <returns>A task producing the constructed value.</returns>
        ValueTask<TBuilt> BuildAsync(CancellationToken ct = default);
    }
}
