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

    // Buttons & Actions
    public static string Btn_Save => ResourceManager.GetString("Btn_Save", resourceCulture) ?? "Uložiť";
    public static string Btn_Cancel => ResourceManager.GetString("Btn_Cancel", resourceCulture) ?? "Zrušiť";
    public static string Btn_Edit => ResourceManager.GetString("Btn_Edit", resourceCulture) ?? "Upraviť";
    public static string Btn_Delete => ResourceManager.GetString("Btn_Delete", resourceCulture) ?? "Vymazať";
    public static string Btn_Add => ResourceManager.GetString("Btn_Add", resourceCulture) ?? "Pridať";
    public static string Col_Actions => ResourceManager.GetString("Col_Actions", resourceCulture) ?? "Akcie";

    // Messages
    public static string Msg_ConfirmDelete => ResourceManager.GetString("Msg_ConfirmDelete", resourceCulture) ?? "Naozaj chcete vymazať tento záznam?";
    public static string Msg_NoRecords => ResourceManager.GetString("Msg_NoRecords", resourceCulture) ?? "Žiadne záznamy sa nenašli.";
    public static string Loading => ResourceManager.GetString("Loading", resourceCulture) ?? "Načítavam...";

    // Common Labels
    public static string Label_Model => ResourceManager.GetString("Label_Model", resourceCulture) ?? "Model";
    public static string Label_Plate => ResourceManager.GetString("Label_Plate", resourceCulture) ?? "ŠPZ";
    public static string Label_ValidTo => ResourceManager.GetString("Label_ValidTo", resourceCulture) ?? "Platnosť do";
    public static string Label_EmissionValidTo => ResourceManager.GetString("Label_EmissionValidTo", resourceCulture) ?? "Emisná kontrola do";
    public static string Label_ServiceValidTo => ResourceManager.GetString("Label_ServiceValidTo", resourceCulture) ?? "Servisná prehliadka do";

    // Legacy (Login) - Budeme postupne migrovať do LangLogin, ale zatiaľ nechám pre spätnú kompatibilitu ak som niečo zabudol
    public static string Login_Title => ResourceManager.GetString("Login_Title", resourceCulture) ?? "Prihlásenie";
}
