using ArcBlazor.Utilities;
using Microsoft.AspNetCore.Components;

namespace ArcBlazor;

public partial class ArcNavBar : ArcComponentBase
{
    private string ClassName => 
        new CssBuilder("navbar")
            .AddClass("navbar-expand-md")
            .AddClass("navbar-dark", IsDark)
            .AddClass("navbar-light", !IsDark)
            .AddClass("sticky-top", Fixed)
            .AddClass("d-print-none")
            .AddClass(Class)
            .Build();

    private string ContainerClassName =>
        new CssBuilder()
            .AddClass("container-fluid", Fluid)
            .AddClass("container", !Fluid)
            .Build();
    
    /// <summary>
    /// If true, navbar uses dark version
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.NavBar.Appearance)]
    public bool IsDark { get; set; } = true;
    
    /// <summary>
    /// If true, navbar will be Fixed.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.NavBar.Behaviour)]
    public bool Fixed { get; set; } = true;

    /// <summary>
    /// If true, navbar utilises full space
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.NavBar.Appearance)]
    public bool Fluid { get; set; } = true;
    
    /// <summary>
    /// Child content of the component.
    /// </summary>
    [Parameter]
    [Category(CategoryTypes.NavBar.Behaviour)]
    public RenderFragment ChildContent { get; set; }
}   