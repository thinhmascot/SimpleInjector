﻿// Copyright (c) Simple Injector Contributors. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for license information.

namespace SimpleInjector.Fluent
{
    using System;

    /// <summary>TODO</summary>
    public interface ICollectionRegistrationResult
    {
        /// <summary>TODO</summary>
        Container Container { get; }

        /// <summary>TODO</summary>
        Type ElementType { get; }
    }
}