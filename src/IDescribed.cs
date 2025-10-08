// <copyright file="IDescribed.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Simple description contract frequently used by definitions and descriptors.
    /// </summary>
    public interface IDescribed
    {
        /// <summary>
        /// Human-friendly description of the entity. This value is optional and may be null
        /// when no description has been provided.
        /// </summary>
        string? Description { get; }
    }
}
