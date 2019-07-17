using System;

public static class TwoFer
{
    public static string Speak(string name = "")
    {
        return "One for " + (name != "" ? name : "you") + ", one for me.";
    }
}
