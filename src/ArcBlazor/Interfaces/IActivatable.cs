using Microsoft.AspNetCore.Components.Web;

namespace ArcBlazor.Interfaces;

public interface IActivatable
{
    void Activate(object activator, MouseEventArgs args);
}