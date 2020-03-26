using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace ProseKit.AspNetCore.TagHelpers
{
	[HtmlTargetElement("prose-editor", Attributes = SchemaAttributeName, TagStructure = TagStructure.WithoutEndTag)]
	public class ProseEditorTagHelper : TagHelper
	{
		private const string SchemaAttributeName = "schema";

		public Schema Schema { get; set; } = Schema.Empty;

		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			return base.ProcessAsync(context, output);
		}
	}
}
