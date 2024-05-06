using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Teste;

public class ProgressHeader : IDynamicComponent<int>
{
    public int State { get; set; }
    
    public DynamicComponentComposeResult Compose(DynamicContext context)
    {
        var content = context.CreateElement(container =>
        {
            var width = context.AvailableSize.Width * context.PageNumber / context.TotalPages;
            
            container
                .Background(Colors.Blue.Lighten2)
                .Height(25)
                .Width(width)
                .Background(Colors.Blue.Darken1);
        });

        return new DynamicComponentComposeResult
        {
            Content = content,
            HasMoreContent = false
        };
    }
}