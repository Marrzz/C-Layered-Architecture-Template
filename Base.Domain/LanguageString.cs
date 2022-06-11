namespace Base.Domain;

public class LanguageString : Dictionary<string, string>
{
    private const string DefaultCulture = "en";

    public new string this[string key]
    {
        get { return base[key]; }
        set { base[key] = value; }
    }

    public LanguageString(string value) : this(value, Thread.CurrentThread.CurrentUICulture.Name)
    {
    }


    public LanguageString()
    {
    }

    public LanguageString(string value, string culture)
    {
        this[culture] = value;
    }

    public void SetTranslation(string value)
    {
        this[Thread.CurrentThread.CurrentUICulture.Name] = value;
    }

    public string? Translate(string? culture = null)
    {
        if (this.Count == 0) return null;

        culture = culture?.Trim() ?? Thread.CurrentThread.CurrentUICulture.Name;
        
        if (this.ContainsKey(culture))
        {
            return this[culture];
        }

       
        var key = this.Keys.FirstOrDefault(t => culture.StartsWith(t));
        if (key != null)
        {
            return this[key];
        }

        
        key = this.Keys.FirstOrDefault(t => culture.StartsWith(DefaultCulture));
        if (key != null)
        {
            return this[key];
        }

        
        return null;
    }

    public override string ToString()
    {
        return Translate() ?? "err: Translation Missing";
    }

    public static implicit operator string(LanguageString? l) => l?.ToString() ?? "null";
    public static implicit operator LanguageString(string s) => new LanguageString(s);
}
