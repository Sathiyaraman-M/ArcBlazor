using System.ComponentModel;

namespace ArcBlazor;

public enum CardStatusPosition
{
    None,
    [Description("card-status-top")]
    Top,
    [Description("card-status-left")]
    Left
}