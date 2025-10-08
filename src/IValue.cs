// <copyright file="IValue.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core
{
    /// <summary>
    /// Represents a conceptual value — a concrete, immutable data form.
    /// Implementing types SHOULD be immutable and define equality by value.
    /// </summary>
    public interface IValue : IConcept { }
}
