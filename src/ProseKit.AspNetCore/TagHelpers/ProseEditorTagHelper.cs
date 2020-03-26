using Microsoft.AspNetCore.Razor.TagHelpers;
using ProseKit.AspNetCore.Services;
using System.Threading.Tasks;

namespace ProseKit.AspNetCore.TagHelpers
{
	[HtmlTargetElement("prose-editor", Attributes = SchemaAttributeName, TagStructure = TagStructure.WithoutEndTag)]
	public class ProseEditorTagHelper : TagHelper
	{
		private const string SchemaAttributeName = "schema";
		private readonly ProseContext _proseContext;

		public Schema Schema { get; set; } = Schema.Empty;

		public ProseEditorTagHelper(ProseContext proseContext)
		{
			_proseContext = proseContext;
		}

		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			_proseContext.RequireSchema(Schema);
			return base.ProcessAsync(context, output);
		}
	}
}
