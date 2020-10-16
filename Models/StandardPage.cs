using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaBackend.Models
{
    [PageType(Title = "Standard Page", UseBlocks = false)]
    public class StandardPage : Page<StandardPage>
    {
        [Region]
        public HtmlField Body { get; set; }
    }
}