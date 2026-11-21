using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000AB RID: 171
	internal sealed class PreserveReferenceHandler : ReferenceHandler
	{
		// Token: 0x060009D2 RID: 2514 RVA: 0x000235D5 File Offset: 0x000217D5
		public override ReferenceResolver CreateResolver()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002A486 File Offset: 0x00028686
		internal override ReferenceResolver CreateResolver(bool writing)
		{
			return new PreserveReferenceResolver(writing);
		}
	}
}
