﻿////*********************************************************
// <copyright file="SerializationFormat.cs" company="Intuit">
/*******************************************************************************
 * Copyright 2016 Intuit
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *******************************************************************************/
// <summary>This file contains SdkException.</summary>
// <summary>This file contains serialization format enumeration.</summary>
////*********************************************************

namespace Intuit.Ipp.Core.Configuration
{
    /// <summary>
    /// Serialization format enumeration.
    /// </summary>
    public enum SerializationFormat
    {
        /// <summary>
        /// Xml Serialization Format.
        /// </summary>
        Xml,

        /// <summary>
        /// Java Script Obejct Notation Serialization Format.
        /// </summary>
        Json,

        /// <summary>
        /// Custom serialization format.
        /// </summary>
        Custom
    }
}
