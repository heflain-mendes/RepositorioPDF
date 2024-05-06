using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace relatorioPDF;

public class Report : IDocument
{
    private IReportHandler? _reportHandler;

    public Report(IReportHandler reportHandler)
    {
        _reportHandler = reportHandler;
    }
    public void Compose(IDocumentContainer documentContainer)
    {
        documentContainer.Page(
            page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Content().Column(
                    column =>
                    {
                        this._reportHandler?.Handler(column);
                    });
            }
        );
    }
}
