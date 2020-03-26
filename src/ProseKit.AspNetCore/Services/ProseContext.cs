using System.Collections.Generic;
using System.Linq;

namespace ProseKit.AspNetCore.Services
{
	public class ProseContext
	{
		private readonly List<Schema> _requiredSchemas = new List<Schema>();

		public IEnumerable<Schema> RequiredSchemas => _requiredSchemas;

		public void RequireSchema(Schema schema)
		{
			if (!_requiredSchemas.Any(q => ReferenceEquals(schema, q)))
				_requiredSchemas.Add(schema);
		}
	}
}
