using System.Runtime.InteropServices;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace relatorioPDF;

public interface IReportHandler
{
    void SetNext(IReportHandler reportHandler);
    void Handler(ColumnDescriptor column);
}