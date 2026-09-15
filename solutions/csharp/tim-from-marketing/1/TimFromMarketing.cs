static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string result = "";

        if (id != null)
        {
            result += $"[{id}] - ";
        }

        result += name + " - ";

        if (department == null)
        {
            result += "OWNER";
        }
        else
        {
            result += department.ToUpper();
        }

        return result;
    }
}
