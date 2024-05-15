﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace CarWash.Service.Converters
{
    public class TimeOnlyComparer:ValueComparer<TimeOnly>
    {
        public TimeOnlyComparer() : base(
            (x,y) => x.Ticks==y.Ticks,
            timeOnly => timeOnly.GetHashCode())
        { }
    }
}
