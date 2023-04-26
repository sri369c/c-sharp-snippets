public static DateTime ConvertUtcToLocalTime(string utcTimeString)
{
    DateTime utcTime = DateTime.ParseExact(utcTimeString, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
    TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
    DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, localTimeZone);
    return localTime;
}

/*
string utcTimeString = "04/26/2023 02:30:00 PM";
DateTime localTime = ConvertUtcToLocalTime(utcTimeString);
Console.WriteLine($"UTC time: {utcTimeString}");
Console.WriteLine($"Local time: {localTime}");
*/
