﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
namespace SiliconStudio.Paradox.UI
{
    /// <summary>
    /// Describes how content is resized to fill its allocated space.
    /// </summary>
    public enum StretchType
    {
        /// <summary>
        /// The content preserves its original size.
        /// </summary>
        None,

        /// <summary>
        /// The content is resized to fit in the destination dimensions while it preserves its native aspect ratio.
        /// </summary>
        Uniform,

        /// <summary>
        /// The content is resized to fill the destination dimensions while it preserves its native aspect ratio. 
        /// If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit in the destination dimensions.
        /// </summary>
        UniformToFill,

        /// <summary>
        /// The content is resized to fill the destination when stretched by its parent. It keeps its ratio otherwise.
        /// </summary>
        FillOnStretch,

        /// <summary>
        /// The content is always resized to fill the destination dimensions. The aspect ratio is not preserved.
        /// </summary>
        Fill,
    }
}