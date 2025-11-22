namespace ProCleaningBlazorAi.WebUI.Resources;

public class LangPlatforms
{
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;

    internal LangPlatforms() { }

    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProCleaningBlazorAi.WebUI.Resources.LangPlatforms", typeof(LangPlatforms).Assembly);
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

    public static string Title_Index => ResourceManager.GetString("Title_Index", resourceCulture) ?? "Plošiny";
    public static string Title_New => ResourceManager.GetString("Title_New", resourceCulture) ?? "Nová plošina";
    public static string Title_Edit => ResourceManager.GetString("Title_Edit", resourceCulture) ?? "Úprava plošiny";
    public static string Msg_ConfirmDelete => ResourceManager.GetString("Msg_ConfirmDelete", resourceCulture) ?? "Naozaj chcete vymazať túto plošinu?";
    public static string Btn_Add => ResourceManager.GetString("Btn_Add", resourceCulture) ?? "Pridať plošinu";
    
    // Validation
    public static string Val_ModelRequired => ResourceManager.GetString("Val_ModelRequired", resourceCulture) ?? "Model je povinný.";
    public static string Val_PlateRequired => ResourceManager.GetString("Val_PlateRequired", resourceCulture) ?? "ŠPZ je povinná.";
}
