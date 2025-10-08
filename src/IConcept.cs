// <copyright file="IConcept.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

using System;

namespace Zentient.Core
{
    /// <summary>
    /// Represents the most fundamental semantic unit within the Zentient framework.
    /// A concept is a uniquely identifiable abstraction forming the foundation of
    /// all higher-level definitions. Implementations SHOULD be immutable and
    /// equality semantics are expected to be stable across process boundaries.
    /// </summary>
    public interface IConcept : IIdentifiable<string>, IEquatable<IConcept> { }
}
