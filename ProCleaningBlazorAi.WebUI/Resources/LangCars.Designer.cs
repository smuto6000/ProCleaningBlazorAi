namespace ProCleaningBlazorAi.WebUI.Resources;

public class LangCars
{
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;

    internal LangCars() { }

    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProCleaningBlazorAi.WebUI.Resources.LangCars", typeof(LangCars).Assembly);
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

    public static string Title_Index => ResourceManager.GetString("Title_Index", resourceCulture) ?? "Autá";
    public static string Title_New => ResourceManager.GetString("Title_New", resourceCulture) ?? "Nové auto";
    public static string Title_Edit => ResourceManager.GetString("Title_Edit", resourceCulture) ?? "Úprava auta";
    public static string Label_Vin => ResourceManager.GetString("Label_Vin", resourceCulture) ?? "VIN";
    public static string Label_VignetteValidTo => ResourceManager.GetString("Label_VignetteValidTo", resourceCulture) ?? "Diaľničná známka do";
    public static string Msg_ConfirmDelete => ResourceManager.GetString("Msg_ConfirmDelete", resourceCulture) ?? "Naozaj chcete vymazať toto auto?";
    public static string Btn_Add => ResourceManager.GetString("Btn_Add", resourceCulture) ?? "Pridať auto";
    
    // Validation
    public static string Val_ModelRequired => ResourceManager.GetString("Val_ModelRequired", resourceCulture) ?? "Model je povinný.";
    public static string Val_PlateRequired => ResourceManager.GetString("Val_PlateRequired", resourceCulture) ?? "ŠPZ je povinná.";
}
