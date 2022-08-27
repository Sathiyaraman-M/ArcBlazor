using System.ComponentModel;

namespace ArcBlazor;

public enum ButtonType
{
    [Description("button")]
    Button,
    [Description("submit")]
    Submit,
    [Description("reset")]
    Reset
}