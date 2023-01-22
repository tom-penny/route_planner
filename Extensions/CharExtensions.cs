namespace RoutePlanner.Extensions;

public static class CharExtensions
{
    public static bool A_C(this char c)
    {
        return c is >= 'a' and <= 'c' or >= 'A' and <= 'C';
    }
    public static bool D_F(this char c)
    {
        return c is >= 'd' and <= 'f' or >= 'D' and <= 'F';
    }
    public static bool G_I(this char c)
    {
        return c is >= 'g' and <= 'i' or >= 'G' and <= 'I';
    }
    public static bool J_L(this char c)
    {
        return c is >= 'j' and <= 'l' or >= 'J' and <= 'L';
    }
    public static bool M_O(this char c)
    {
        return c is >= 'm' and <= 'o' or >= 'M' and <= 'O';
    }
    public static bool P_R(this char c)
    {
        return c is >= 'p' and <= 'r' or >= 'P' and <= 'R';
    }
    public static bool S_U(this char c)
    {
        return c is >= 's' and <= 'u' or >= 'S' and <= 'U';
    }
    public static bool V_Z(this char c)
    {
        return c is >= 'V' and <= 'z' or >= 'V' and <= 'Z';
    }
}