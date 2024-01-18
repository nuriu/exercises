using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    private enum STATEMENT_TYPES
    {
        SILENCE,
        YELLING,
        QUESTIONING,
        YELLING_AND_QUESTIONING,
        SOMETHING_ELSE
    }

    private static readonly Dictionary<STATEMENT_TYPES, string> ANSWERS = new Dictionary<STATEMENT_TYPES, string>()
    {
        {STATEMENT_TYPES.SILENCE, "Fine. Be that way!"},
        {STATEMENT_TYPES.YELLING, "Whoa, chill out!"},
        {STATEMENT_TYPES.QUESTIONING, "Sure."},
        {STATEMENT_TYPES.YELLING_AND_QUESTIONING, "Calm down, I know what I'm doing!"},
        {STATEMENT_TYPES.SOMETHING_ELSE, "Whatever."}
    };

    public static string Response(string statement) => ANSWERS[ClassificateStatement(statement)];

    private static STATEMENT_TYPES ClassificateStatement(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
        {
            return STATEMENT_TYPES.SILENCE;
        }

        var isYelling = statement.Trim().Any(char.IsLetter) && string.CompareOrdinal(statement.ToUpper(), statement) == 0;
        var isQuestioning = statement.Trim().Last() == '?';

        if (isYelling && !isQuestioning)
        {
            return STATEMENT_TYPES.YELLING;
        }

        if (!isYelling && isQuestioning)
        {
            return STATEMENT_TYPES.QUESTIONING;
        }

        if (isYelling && isQuestioning)
        {
            return STATEMENT_TYPES.YELLING_AND_QUESTIONING;
        }

        return STATEMENT_TYPES.SOMETHING_ELSE;
    }
}
