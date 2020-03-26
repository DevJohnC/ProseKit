namespace ProseKit
{
	public partial class Schema
	{
		public static readonly Schema Empty = new Schema(
			NodeCollection.Empty,
			MarkCollection.Empty
			);

		public Schema(NodeCollection nodes, MarkCollection marks)
		{

		}
	}
}
