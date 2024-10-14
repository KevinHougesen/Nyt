using Piral.Blazor.Core;

namespace Nyt.NewsFeed
{
    public partial class Module : IModule
    {
        public void Init(IBlazorPilet pilet)
        {
            pilet.RegisterPage("/newsfeed", typeof(Module));
        }
    }
}