using Elastic.Xunit.XunitPlumbing;
using Nest;
using System.ComponentModel;

namespace Examples.Ilm.Apis
{
	public class RemovePolicyFromIndexPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		[Description("ilm/apis/remove-policy-from-index.asciidoc:83")]
		public void Line83()
		{
			// tag::8bec5a437f4aea6f3f897c9df2ce2442[]
			var response0 = new SearchResponse<object>();
			// end::8bec5a437f4aea6f3f897c9df2ce2442[]

			response0.MatchesExample(@"POST my_index/_ilm/remove");
		}
	}
}