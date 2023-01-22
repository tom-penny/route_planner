using RoutePlanner.Controllers.Input;

namespace RoutePlanner.Helpers;

public static class UserSelection
{
    public static T? SelectElement<T>(T[] arr, string prompt = "Select {0}:")
    {
        return arr.Length > 0 ? arr[SelectionReader<T>.Read(arr, string.Format(prompt, typeof(T).Name))] : default;
    }
    public static T1? SelectElement<T1, T2>(T1[] arr, T2[] overrides, string prompt = "Select {0}:")
    {
        if (overrides.Length != arr.Length) throw new IndexOutOfRangeException("Arrays must be equal length.");
        return arr.Length > 0 ? arr[SelectionReader<T2>.Read(overrides, string.Format(prompt, typeof(T1).Name))] : default;
    }
    public static T? SelectElement<T>(IEnumerable<T> list, string prompt = "Select {0}:")
    {
        var arr = list.ToArray();
        return arr.Length > 0 ? arr[SelectionReader<T>.Read(arr, string.Format(prompt, typeof(T).Name))] : default;
    }
    public static T1? SelectElement<T1, T2>(IEnumerable<T1> list, T2[] overrides, string prompt = "Select {0}:")
    {
        var arr = list.ToArray();
        if (overrides.Length != arr.Length) throw new IndexOutOfRangeException("Arrays must be equal length.");
        return arr.Length > 0 ? arr[SelectionReader<T2>.Read(overrides, string.Format(prompt, typeof(T1).Name))] : default;
    }

    public static bool SelectBool(string prompt, string first, string second)
    {
        return new[] { true, false }[SelectionReader<string>.Read(new[] { first, second }, prompt)];
    }
}