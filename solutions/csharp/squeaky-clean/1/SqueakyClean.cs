public static class Identifier
{
    public static string Clean(string identifier)
    {
         string result = "";
        bool nextUpper = false;

        foreach (char character in identifier)
        {
            if (character == '-')
            {
                nextUpper = true;
            }
            else if (char.IsControl(character))
            {
                result += "CTRL";
            }
            else if (character == ' ')
            {
                result += '_';
            }
            else if (char.IsLetter(character))
            {
                if (nextUpper)
                {
                    result += char.ToUpper(character);
                    nextUpper = false;
                }
                else if (character < 'α' || character > 'ω')
                {
                    result += character;
                }
            }
        }

        return result;
    }
}
