using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace ProseKit.AspNetCore.TagHelpers
{
	[HtmlTargetElement("prose-header", TagStructure = TagStructure.WithoutEndTag)]
	public class ProseHeaderTagHelper : TagHelper
	{
		private ICompositeViewEngine _viewEngine;

		private IViewBufferScope _viewBufferScope;

		public ProseHeaderTagHelper(ICompositeViewEngine viewEngine, IViewBufferScope viewBufferScope)
		{
			_viewEngine = viewEngine;
			_viewBufferScope = viewBufferScope;
		}

		[ViewContext]
		public ViewContext? ViewContext { get; set; }

		public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			var viewRenderer = new PartialTagHelper(_viewEngine, _viewBufferScope)
			{
				ViewContext = ViewContext,
				Model = null,
				Name = "Prose/_ProseHeader"
			};

			return viewRenderer.ProcessAsync(context, output);
		}
	}
}
