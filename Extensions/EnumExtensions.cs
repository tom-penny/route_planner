using RoutePlanner;

namespace RoutePlanner.Extensions;

public static class EnumExtensions
{
    public static bool Validate(this CharacterType type, char c) => type switch
    {
        CharacterType.Any => true,
        CharacterType.Letter => char.IsLetter(c),
        CharacterType.Digit => char.IsDigit(c),
        CharacterType.DecimalDigit => c == '.' || char.IsDigit(c),
        CharacterType.LetterOrDigit => char.IsLetterOrDigit(c),
        _ => throw new NotSupportedException()
    };

    public static bool InService(this ServiceHours hours) => hours switch
    {
        ServiceHours.Regular => TimeOnly.FromDateTime(DateTime.UtcNow).IsBetween(new TimeOnly(05, 00), new TimeOnly(00, 00)),
        ServiceHours.Extended => DateTime.UtcNow.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday || ServiceHours.Regular.InService(),
    };
    //|| TimeOnly.FromDateTime(DateTime.UtcNow).IsBetween(new TimeOnly(05, 00), new TimeOnly(00, 00))
}