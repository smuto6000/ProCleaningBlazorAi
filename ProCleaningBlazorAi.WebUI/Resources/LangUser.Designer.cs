namespace ProCleaningBlazorAi.WebUI.Resources;

public class LangUser
{
    private static global::System.Resources.ResourceManager resourceMan;
    private static global::System.Globalization.CultureInfo resourceCulture;

    internal LangUser() { }

    public static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ProCleaningBlazorAi.WebUI.Resources.LangUser", typeof(LangUser).Assembly);
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

    public static string Title_Index => ResourceManager.GetString("Title_Index", resourceCulture) ?? "Zamestnanci";
    public static string Title_New => ResourceManager.GetString("Title_New", resourceCulture) ?? "Nový zamestnanec";
    public static string Title_Update => ResourceManager.GetString("Title_Update", resourceCulture) ?? "Úprava zamestnanca";
    
    public static string Btn_Add => ResourceManager.GetString("Btn_Add", resourceCulture) ?? "Pridať zamestnanca";
    public static string Btn_Save => ResourceManager.GetString("Btn_Save", resourceCulture) ?? "Uložiť";
    public static string Btn_Cancel => ResourceManager.GetString("Btn_Cancel", resourceCulture) ?? "Zrušiť";
    public static string Btn_Delete => ResourceManager.GetString("Btn_Delete", resourceCulture) ?? "Vymazať";
    
    public static string Col_FirstName => ResourceManager.GetString("Col_FirstName", resourceCulture) ?? "Meno";
    public static string Col_LastName => ResourceManager.GetString("Col_LastName", resourceCulture) ?? "Priezvisko";
    public static string Col_Email => ResourceManager.GetString("Col_Email", resourceCulture) ?? "Email";
    public static string Col_Role => ResourceManager.GetString("Col_Role", resourceCulture) ?? "Rola";
    public static string Col_Actions => ResourceManager.GetString("Col_Actions", resourceCulture) ?? "Akcie";
    
    public static string Label_Password => ResourceManager.GetString("Label_Password", resourceCulture) ?? "Heslo";
    public static string Msg_SuccessCreated => ResourceManager.GetString("Msg_SuccessCreated", resourceCulture) ?? "Zamestnanec úspešne vytvorený.";
    public static string Msg_SuccessUpdated => ResourceManager.GetString("Msg_SuccessUpdated", resourceCulture) ?? "Zamestnanec úspešne upravený.";
    public static string Msg_SuccessDeleted => ResourceManager.GetString("Msg_SuccessDeleted", resourceCulture) ?? "Zamestnanec úspešne vymazaný.";
    public static string Msg_ConfirmDelete => ResourceManager.GetString("Msg_ConfirmDelete", resourceCulture) ?? "Naozaj chcete vymazať tohto zamestnanca?";
}

