using System.Collections;
using System.Collections.Generic;

namespace ProseKit
{
	public class MarkCollection : IEnumerable<KeyValuePair<string, object>>
	{
		public static readonly MarkCollection Empty = new MarkCollection();

		public void Add(string key, object mark)
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
