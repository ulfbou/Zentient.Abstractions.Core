// <copyright file="INamed.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Provides a stable, human-friendly name for a concept.
    /// </summary>
    public interface INamed : IConcept
    {
        /// <summary>
        /// Gets the human-friendly name.
        /// </summary>
        string Name { get; }
    }
}
