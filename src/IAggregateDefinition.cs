// <copyright file="IAggregateDefinition.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Represents an aggregate definition that composes multiple child definitions.
    /// Useful for composed artifacts such as policies or composite schemas.
    /// </summary>
    public interface IAggregateDefinition : IDefinition
    {
        /// <summary>
        /// Gets the read-only sequence of component definitions.
        /// </summary>
        IEnumerable<IDefinition> Components { get; }
    }
}
