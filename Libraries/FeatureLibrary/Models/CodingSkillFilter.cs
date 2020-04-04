﻿using System.Collections.Generic;

namespace FeatureLibrary.Models
{
    /// <summary>
    /// Coding skill filter.
    /// </summary>
    public class CodingSkillFilter
    {
        /// <summary>
        /// Level filter
        /// </summary>
        public List<CodingSkillLevel> Levels { get; set; }
        /// <summary>
        /// Name filter
        /// </summary>
        public string Name { get; set; }
    }
}
