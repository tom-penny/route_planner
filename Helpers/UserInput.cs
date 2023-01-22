using RoutePlanner.Controllers.Input;
using RoutePlanner.Extensions;

namespace RoutePlanner.Helpers;

public static class UserInput
{
    public static T Read<T>(InputType inputType)
    {
        for (var i = 0; i < 10; i++)
        {
            if (Reader(inputType) is T output) return output;
            "Invalid entry. Please try again.".ToConsole(true);
        }
        throw new ArgumentException("An unknown error occurred. Please contact support or try again.");
    }

    private static dynamic? Reader(InputType inputType) => inputType switch
    {
        InputType.Time => ReadTime(),
        InputType.Station => ReadStation()
    };
    private static string? ReadStation()
    {
        return FieldReader.Read(CharacterType.Letter, 30, "Enter Search:", true);
    }
    private static TimeSpan? ReadTime()
    {
        var input = FieldReader.Read(CharacterType.Digit, 8, "Enter time (00:00:00):", false, true, (3, ':'), (6, ':'));
        return TimeSpan.TryParse(input, out var result) ? result : null;
    }
}