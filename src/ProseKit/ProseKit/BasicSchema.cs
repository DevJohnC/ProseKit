namespace ProseKit
{
	public class BasicSchema : Schema
	{
		private const string GROUP_BLOCK = "block";
		private const string GROUP_INLINE = "inline";
		private const string CONTENT_ONE_OR_MORE_BLOCKS = "block+";
		private const string CONTENT_NONE_OR_MORE_INLINES = "inline*";

		private static readonly NodeCollection _nodes = new NodeCollection
		{
			{ "doc", new NodeSpec(content: CONTENT_ONE_OR_MORE_BLOCKS) },
			{ "paragraph", new NodeSpec(content: CONTENT_NONE_OR_MORE_INLINES, group: GROUP_BLOCK, parseDOM: new[] { new { tag = "p" } }, toDOM: "[\"p\", 0]") },
			{ "blockquote", new NodeSpec(content: CONTENT_ONE_OR_MORE_BLOCKS, group: GROUP_BLOCK, parseDOM: new[] { new { tag = "blockquote" } }, toDOM: "[\"blockquote\", 0]") }
		};

		private static readonly MarkCollection _marks = MarkCollection.Empty;

		public static readonly BasicSchema Schema = new BasicSchema();

		private BasicSchema() :
			base("BasicSchema", _nodes, _marks)
		{
		}
	}
}
