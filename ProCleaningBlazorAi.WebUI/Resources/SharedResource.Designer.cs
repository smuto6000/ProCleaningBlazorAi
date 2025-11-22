namespace ProCleaningBlazorAi.WebUI.Resources;

public class SharedResource
{
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;

    internal SharedResource() { }

    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProCleaningBlazorAi.WebUI.Resources.SharedResource", typeof(SharedResource).Assembly);
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

    // Login
    public static string Login_Title => ResourceManager.GetString("Login_Title", resourceCulture) ?? "Prihlásenie";
    public static string Login_Subtitle => ResourceManager.GetString("Login_Subtitle", resourceCulture) ?? "Prihláste sa do svojho účtu";
    public static string Login_EmailLabel => ResourceManager.GetString("Login_EmailLabel", resourceCulture) ?? "Email";
    public static string Login_PasswordLabel => ResourceManager.GetString("Login_PasswordLabel", resourceCulture) ?? "Heslo";
    public static string Login_ForgotPassword => ResourceManager.GetString("Login_ForgotPassword", resourceCulture) ?? "Zabudli ste heslo?";
    public static string Login_RememberMe => ResourceManager.GetString("Login_RememberMe", resourceCulture) ?? "Zapamätať si ma";
    public static string Login_Button => ResourceManager.GetString("Login_Button", resourceCulture) ?? "Prihlásiť sa";
    public static string Login_ButtonLoading => ResourceManager.GetString("Login_ButtonLoading", resourceCulture) ?? "Overujem...";
    public static string Login_FooterCopyright => ResourceManager.GetString("Login_FooterCopyright", resourceCulture) ?? "ProCleaning Systems";

    // Errors
    public static string Error_InvalidCredentials => ResourceManager.GetString("Error_InvalidCredentials", resourceCulture) ?? "Nesprávne prihlasovacie údaje.";
    public static string Error_ConnectionFailed => ResourceManager.GetString("Error_ConnectionFailed", resourceCulture) ?? "Chyba spojenia so serverom.";

    // Validation
    public static string Validation_EmailRequired => ResourceManager.GetString("Validation_EmailRequired", resourceCulture) ?? "Email je povinný.";
    public static string Validation_EmailInvalid => ResourceManager.GetString("Validation_EmailInvalid", resourceCulture) ?? "Zadajte platný email.";
    public static string Validation_PasswordRequired => ResourceManager.GetString("Validation_PasswordRequired", resourceCulture) ?? "Heslo je povinné.";
}

