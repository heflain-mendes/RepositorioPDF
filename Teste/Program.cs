using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using relatorioPDF;
using relatorioPDF.ReportHandlerFactories;

QuestPDF.Settings.License = LicenseType.Community;

new Report(new ReportHandlerFactory().Create()).ShowInPreviewer();