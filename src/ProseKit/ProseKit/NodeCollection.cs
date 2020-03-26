using System.Collections;
using System.Collections.Generic;

namespace ProseKit
{
	public class NodeCollection : IEnumerable<KeyValuePair<string, object>>
	{
		public static readonly NodeCollection Empty = new NodeCollection();

		public void Add(string key, NodeSpec nodeSpec)
		{
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			throw new System.NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
	}
}
