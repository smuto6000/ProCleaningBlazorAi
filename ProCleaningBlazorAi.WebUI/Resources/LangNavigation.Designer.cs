namespace ProCleaningBlazorAi.WebUI.Resources;

public class LangNavigation
{
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;

    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal LangNavigation() { }

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProCleaningBlazorAi.WebUI.Resources.LangNavigation", typeof(LangNavigation).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    public static global::System.Globalization.CultureInfo Culture
    {
        get { return resourceCulture; }
        set { resourceCulture = value; }
    }

    public static string Section_Main => ResourceManager.GetString("Section_Main", resourceCulture) ?? "Hlavné";
    public static string Section_CodeLists => ResourceManager.GetString("Section_CodeLists", resourceCulture) ?? "Číselníky";
    public static string Home => ResourceManager.GetString("Home", resourceCulture) ?? "Domov";
    public static string WorkOverview => ResourceManager.GetString("WorkOverview", resourceCulture) ?? "Prehľad prác";
    public static string Employees => ResourceManager.GetString("Employees", resourceCulture) ?? "Zamestnanci";
    public static string Wages => ResourceManager.GetString("Wages", resourceCulture) ?? "Mzdy";
    public static string Cars => ResourceManager.GetString("Cars", resourceCulture) ?? "Autá";
    public static string Platforms => ResourceManager.GetString("Platforms", resourceCulture) ?? "Plošiny";
    public static string Carts => ResourceManager.GetString("Carts", resourceCulture) ?? "Vozíky";
}

