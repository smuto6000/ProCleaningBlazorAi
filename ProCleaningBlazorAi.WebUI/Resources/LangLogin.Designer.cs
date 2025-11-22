namespace ProCleaningBlazorAi.WebUI.Resources;

public class LangLogin
{
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;

    internal LangLogin() { }

    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProCleaningBlazorAi.WebUI.Resources.LangLogin", typeof(LangLogin).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }

    public static global::System.Globalization.CultureInfo Culture
    {
        get { return resourceCulture; }
        set { resourceCulture = value; }
    }

    public static string Title => ResourceManager.GetString("Title", resourceCulture) ?? "Prihlásenie";
    public static string Subtitle => ResourceManager.GetString("Subtitle", resourceCulture) ?? "Vitajte späť! Prosím prihláste sa.";
    public static string Label_Email => ResourceManager.GetString("Label_Email", resourceCulture) ?? "Emailová adresa";
    public static string Label_Password => ResourceManager.GetString("Label_Password", resourceCulture) ?? "Heslo";
    public static string Link_ForgotPassword => ResourceManager.GetString("Link_ForgotPassword", resourceCulture) ?? "Zabudli ste heslo?";
    public static string Check_RememberMe => ResourceManager.GetString("Check_RememberMe", resourceCulture) ?? "Zapamätať si ma";
    public static string Btn_Login => ResourceManager.GetString("Btn_Login", resourceCulture) ?? "Prihlásiť sa";
    public static string Footer_Copyright => ResourceManager.GetString("Footer_Copyright", resourceCulture) ?? "ProCleaning. Všetky práva vyhradené.";
    public static string Error_InvalidCredentials => ResourceManager.GetString("Error_InvalidCredentials", resourceCulture) ?? "Nesprávny email alebo heslo.";
    public static string Error_Connection => ResourceManager.GetString("Error_Connection", resourceCulture) ?? "Chyba pripojenia k serveru.";
}

