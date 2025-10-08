// <copyright file="IIdentifiable{out TId}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Defines an abstraction for any entity that exposes an identity of a specific type.
    /// </summary>
    /// <typeparam name="TId">The type of the identifier.</typeparam>
    public interface IIdentifiable<out TId> where TId : notnull
    {
        /// <summary>
        /// Gets the unique identifier associated with this instance.
        /// </summary>
        TId Id { get; }
    }
}
