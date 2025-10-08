// <copyright file="ICompatibilityChecker{in TOld, in TNew}.cs" authors="Zentient Framework Team">
// Copyright © 2025 Zentient Framework Team. All rights reserved.
// </copyright>

namespace Zentient.Core.Compatibility
{
    using System.Collections.Generic;
    using Zentient.Core;

    /// <summary>
    /// Performs compatibility checks between two versions of a specification or concept.
    /// </summary>
    /// <typeparam name="TOld">Type representing the older or legacy specification.</typeparam>
    /// <typeparam name="TNew">Type representing the new or candidate specification.</typeparam>
    public interface ICompatibilityChecker<in TOld, in TNew>
    {
        /// <summary>
        /// Determines whether the new specification is compatible with the old one.
        /// </summary>
        bool IsCompatible(TOld oldSpec, TNew newSpec);

        /// <summary>
        /// Produces a structured, human-friendly compatibility report detailing differences and issues.
        /// </summary>
        string GetCompatibilityReport(TOld oldSpec, TNew newSpec);
    }
}
