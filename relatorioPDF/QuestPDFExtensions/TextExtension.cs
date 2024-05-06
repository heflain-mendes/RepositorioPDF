
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace relatorioPDF;
static class TextExtension
{
	public static void TextInfo(this IContainer container, string textLabel, string textValue)
	{
		container
				.PaddingVertical(5)
				.Text(text =>
				{
					text.Span(textLabel + ": ").Medium();
					text.Span(textValue);
				});
	}

	public static void TextTitle(this IContainer container, string textValue)
	{
		container
      .Padding(10)
      .Text(textValue)
	  .Medium()
      .AlignCenter();
	}
}