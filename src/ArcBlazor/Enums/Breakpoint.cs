using System.ComponentModel;

namespace ArcBlazor;

public enum Breakpoint
{
    [Description("None")]
    None,
    [Description("sm")]
    Sm,
    [Description("md")]
    Md,
    [Description("lg")]
    Lg,
    [Description("xl")]
    Xl,
    [Description("xxl")]
    Xxl
}