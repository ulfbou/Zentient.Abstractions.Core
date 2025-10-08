// <copyright file="IIdentifiable.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Represents an entity or value that exposes a stable <see cref="string"/> identifier.
    /// Convenience specialization for string identifiers.
    /// </summary>
    /// <remarks>
    /// Use for objects that require a stable identity across process boundaries or persistence.
    /// Identifier semantics (uniqueness, format) are defined by the domain.
    /// </remarks>
    public interface IIdentifiable : IIdentifiable<string> { }
}
