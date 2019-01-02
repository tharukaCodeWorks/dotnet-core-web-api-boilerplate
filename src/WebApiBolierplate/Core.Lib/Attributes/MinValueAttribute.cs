﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Lib.Attributes
{
    public class MinValueAttribute : ValidationAttribute
    {
        private long Minimum { get; set; }

        public MinValueAttribute(long minimum)
        {
            Minimum = minimum;
        }

        public override bool IsValid(object value)
        {
            return Convert.ToInt64(value) >= Minimum;
        }
    }
}
