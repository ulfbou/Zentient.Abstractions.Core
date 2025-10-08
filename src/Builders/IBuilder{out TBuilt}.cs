// <copyright file="IBuilder{out TBuilt}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Builders
{
    /// <summary>
    /// Builder contract producing an instance of <typeparamref name="TBuilt"/>.
    /// </summary>
    /// <typeparam name="TBuilt">Type produced by the builder.</typeparam>
    /// <remarks>
    /// This is the canonical, synchronous builder contract intended for fast, in-memory
    /// construction of objects. The Zentient core follows a sync-first policy: prefer
    /// implementing this interface for CPU-bound, non-blocking construction logic.
    ///
    /// If your builder must perform I/O (database/network), implement an async variant
    /// (<see cref="IAsyncBuilder{T}"/>) in your implementation package. 
    /// </remarks>
    public interface IBuilder<out TBuilt>
    {
        /// <summary>
        /// Builds and returns the final object. 
        /// </summary>
        TBuilt Build();
    }
}
