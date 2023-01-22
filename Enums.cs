namespace RoutePlanner;

public enum ServiceHours
{
    Regular,
    Extended,
}
public enum Traversal
{
    PreOrder,
    InOrder,
    PostOrder
}

public enum Direction
{
    Inner,
    Outer,
    Northbound,
    Southbound,
    Eastbound,
    Westbound
}

public enum Zone
{
    Zone1,
    Zone2,
    Zone3,
    Zone4,
    Zone5
}

public enum TubeLine
{
    Bakerloo,
    Central,
    Circle,
    District,
    Jubilee,
    Northern,
    Piccadilly,
    Victoria,
    Overground
}

public enum CharacterType
{
    Any,
    Letter,
    Digit,
    DecimalDigit,
    LetterOrDigit
}

public enum InputType
{
    Time,
    Station
}

public enum VerticalPosition
{
    Upper,
    Lower
}

public enum HorizontalPosition
{
    Left,
    Right
}