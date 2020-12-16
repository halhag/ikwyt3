using System;

namespace IKWYT.Data
{
    public class DateHelper
    {
        public static string ConvertToRelativeDate(DateTime? dateTime, bool firstCharUpper)
        {
            var relativeDate = Convert(dateTime);
            if (firstCharUpper)
            {
                return StringHelper.FirstCharToUpper(relativeDate);
            }
            return relativeDate;
        }

        private static string Convert(DateTime? dateTime)
        {
            if (dateTime == null)
                return "never";
            var now = DateTime.UtcNow;

            if (dateTime < now)
            {
                var timespan = now - dateTime.Value;
                if (timespan.Days < 1)
                {
                    if (timespan.Hours < 1)
                    {
                        if (timespan.Minutes < 1)
                            return "just seconds ago";
                        if (timespan.Minutes < 2)
                            return "a minute ago";
                        return timespan.Minutes + " minutes ago";
                    }
                    return timespan.Hours < 2 ? "an hour ago" : timespan.Hours + " hours ago";
                }
                if (timespan.Days < 2)
                    return "a day ago";
                if (timespan.Days < 31)
                    return timespan.Days + " days ago";
                if (timespan.Days < 61)
                    return "a month ago";
                if (timespan.Days < 365)
                {
                    var months = (int)Math.Floor((double)timespan.Days / 30);
                    return months + " months ago";
                }
                if (timespan.Days < 730)
                    return "a year ago";
                return "a long time ago";
            }
            if (dateTime > now)
            {
                var timespan = dateTime.Value - now;
                if (timespan.Days < 1)
                {
                    if (timespan.Hours < 1)
                    {
                        if (timespan.Minutes < 1)
                            return "in a few seconds";
                        if (timespan.Minutes < 2)
                            return "in a minute";
                        return "in " + timespan.Minutes + " minutes";
                    }
                    if (timespan.Hours < 2)
                        return "in one hour";
                    return "in " + timespan.Hours + " hours";
                }
                if (timespan.Days < 2)
                    return "in a day";
                if (timespan.Days < 31)
                    return "in " + timespan.Days + " days";
                if (timespan.Days < 61)
                    return "in a month";
                if (timespan.Days < 365)
                {
                    var months = (int)Math.Floor((double)timespan.Days / 30);
                    return "in " + months + " months";
                }
                if (timespan.Days < 730)
                    return "in a year";
                return "practically never";
            }

            return "unknown";
        }
    }
}
