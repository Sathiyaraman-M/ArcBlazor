namespace ArcBlazor;

public class CategoryAttribute : Attribute
{
    /// <summary> The name of the category. </summary>
    public string Name { get; }

    public CategoryAttribute(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("The category name cannot be null nor empty.");
        if (!categoryOrder.ContainsKey(name))
            throw new ArgumentException($"The given category name '{name}' isn't in the categoryOrder field.");
        Name = name;
    }

    /// <summary> The order of the category - the greater the number the lower the category will be displayed in the API documentation. </summary>
    public int Order => categoryOrder[Name];

    // Possible categories of component properties and the order in which they are displayed in the API documentation.
    private static readonly Dictionary<string, int> categoryOrder = new()
    {
        ["Data"] = 0, // general category
        ["Validation"] = 1, // general category

        // specific categories associated with data
        ["Validated data"] = 2,
        ["Validation result"] = 3,

        ["Behavior"] = 100, // general category

        ["Header"] = 101,
        ["Rows"] = 102,
        ["Footer"] = 103,

        // specific behaviors of a component
        ["Filtering"] = 200,
        ["Grouping"] = 201,
        ["Expanding"] = 202,
        ["Sorting"] = 203,
        ["Pagination"] = 204,
        ["Selecting"] = 205,
        ["Editing"] = 206,
        ["Click action"] = 207,
        ["Items"] = 208,
        ["Disable"] = 209,
        ["DraggingClass"] = 210,
        ["DropRules"] = 211,

        ["Appearance"] = 300, // general category

        // specific parts of a component together with their behavior and appearance
        ["Popup behavior"] = 400,
        ["Popup appearance"] = 401,
        ["List behavior"] = 402,
        ["List appearance"] = 403,
        ["Picker behavior"] = 404,
        ["Picker appearance"] = 405,
        ["Dot"] = 406,

        // "Miscellaneous" category. In classes inheriting from MudComponentBase it can be used only exceptionally -
        //  - only when the property can define behavior or appearance depending on value of the property.
        ["Misc"] = int.MaxValue - 1,

        ["Common"] = int.MaxValue // general category
    };
}

public static class CategoryTypes
{
    /// <summary>Used in <see cref="ArcComponentBase"/>.</summary>
    public static class ComponentBase
    {
        public const string Common = "Common";
    }

    /// <summary>Used in: <see cref="ArcBaseButton"/>.</summary>
    public static class Button
    {
        public const string Behavior = "Behavior";
        public const string ClickAction = "Click action";
        public const string Appearance = "Appearance";
    }
    
    /// <summary>Used in other base classes.</summary>
    public static class General
    {
        public const string Data = "Data";
        public const string Behavior = "Behavior";
        public const string ClickAction = "Click action";
        public const string Appearance = "Appearance";
    }

    public static class Element
    {
        public const string Misc = "Misc";
    }

    public static class NavBar
    {
        public const string Appearance = "Appearance";
        public const string Behaviour = "Behaviour";
    }

    public static class NavMenu
    {
        public const string Appearance = "Appearance";
        public const string Behaviour = "Behaviour";
        public const string ClickAction = "ClickAction";
    }

    public static class NavItem
    {
        public const string Appearance = "Appearance";
        public const string Behaviour = "Behaviour";
    }
}