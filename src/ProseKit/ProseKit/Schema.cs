namespace ProseKit
{
	public class Schema
	{
		public static readonly Schema Empty = new Schema(
			"EmptySchema",
			NodeCollection.Empty,
			MarkCollection.Empty
			);

		public string Name { get; }

		public NodeCollection Nodes { get; }

		public MarkCollection Marks { get; }

		public Schema(string name, NodeCollection nodes, MarkCollection marks)
		{
			Name = name;
			Nodes = nodes;
			Marks = marks;
		}
	}
}
