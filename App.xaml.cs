using Avalonia;
using Avalonia.Markup.Xaml;

namespace KARE8080
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}