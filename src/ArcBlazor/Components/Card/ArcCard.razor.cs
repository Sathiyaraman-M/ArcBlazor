using ArcBlazor.Extensions;
using ArcBlazor.Utilities;
using Microsoft.AspNetCore.Components;

namespace ArcBlazor;

public partial class ArcCard
{
    private string ClassName => new CssBuilder()
        .AddClass("card")
        .AddClass(Class)
        .Build();

    private string ImageClassName => new CssBuilder()
        .AddClass("card-img-top")
        .AddClass("img-responsive")
        .AddClass(ImageClass)
        .Build();

    private string StatusClassName => new CssBuilder()
        .AddClass(StatusPosition.ToDescriptionString(), StatusPosition != CardStatusPosition.None)
        .AddClass($"bg-{StatusColor.ToDescriptionString()}", StatusPosition != CardStatusPosition.None)
        .Build();

    [Parameter] 
    public CardStatusPosition StatusPosition { get; set; } = CardStatusPosition.None;

    [Parameter]
    public ArcColor StatusColor { get; set; } = ArcColor.Primary;
    
    [Parameter]
    public RenderFragment ImageContent { get; set; }
    
    [Parameter]
    public string ImageClass { get; set; }
    
    [Parameter]
    public RenderFragment HeaderContent { get; set; }
    
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    
    [Parameter]
    public RenderFragment CardActions { get; set; }
}