using Nager.Date;

DateSystem.LicenseKey = "Thank you for supporting open source projects";

Console.WriteLine("Nager.Date");

Console.WriteLine($"Please enter the year, and press enter (default:{DateTime.Today.Year})");
var tempYear = Console.ReadLine();
if (!int.TryParse(tempYear, out var year))
{
    year = DateTime.Today.Year;
}

Console.WriteLine("Please enter the country code, and press enter (default:AT)");
var countryCode = Console.ReadLine();
if (string.IsNullOrEmpty(countryCode))
{
    countryCode = "at";
}

Console.WriteLine($"Calculate holidays for {countryCode.ToUpper()} {year}");
Console.WriteLine("-------------------------------------------------------");

var publicHolidays = DateSystem.GetPublicHolidays(year, countryCode);
foreach (var publicHoliday in publicHolidays)
{
    var counties = publicHoliday.Counties != null ? string.Join(',', publicHoliday.Counties) : "";
    Console.WriteLine($"{publicHoliday.Date:d}{"",3}{publicHoliday.Name,30}{"",3}{publicHoliday.LocalName,30}{"",3}{publicHoliday.Type}{"",3}{counties}");
}
