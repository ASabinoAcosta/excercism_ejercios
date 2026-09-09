public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string> { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count == 0)
        {
            return false;
        }
    
        if (languages[0] == "C#")
        {
            return true;
        }
    
        if (languages.Count >= 2 && languages[1] == "C#")
        {
            if (languages.Count == 2 || languages.Count == 3)
            {
                return true;
            }
        }
    
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        for (int i = 0; i < languages.Count; i++)
        {
            for (int j = i + 1; j < languages.Count; j++)
            {
                if (languages[i] == languages[j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}
