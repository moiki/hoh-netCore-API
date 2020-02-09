using System;

namespace hohsys.API.models
{
    // Day in calendar  to do a trip or work
    public class Schedule: MyEntity
    {
        // Day and time choosed as shchedule day
        public DateTimeOffset Day { get; set; }
        // Describes whether a schedule is complete, pending or canceled
        public string State { get; set; }
        // Related entity
        public virtual WorkRoute WorkRoute { get; set; }

    }
}