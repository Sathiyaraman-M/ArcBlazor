using ArcBlazor.Extensions;
using ArcBlazor.Utilities;
using Microsoft.AspNetCore.Components;

namespace ArcBlazor;

public partial class ArcButton : ArcBaseButton
{
    private string ClassName => new CssBuilder("btn")
        .AddClass($"btn-{Color.ToDescriptionString()}")
        .AddClass("btn-square", Square)
        .AddClass("btn-pill", Pill)
        .AddClass("btn-sm", Size == Size.Small)
        .AddClass("btn-lg", Size == Size.Large)
        .AddClass("disabled", Disabled)
        .AddClass(Class)
        .Build();
    
    [Parameter]
    public bool Square { get; set; }
    
    [Parameter]
    public bool Pill { get; set; }
    
    [Parameter]
    public Size Size { get; set; }

    [Parameter] 
    public Color Color { get; set; } = Color.Primary;

    [Parameter]
    public string StartIcon { get; set; }
    
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter] 
    public string EndIcon { get; set; }
}