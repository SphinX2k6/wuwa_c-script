using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A3 RID: 163
	internal sealed class IgnoreReferenceHandler : ReferenceHandler
	{
		// Token: 0x06000951 RID: 2385 RVA: 0x00029450 File Offset: 0x00027650
		public IgnoreReferenceHandler()
		{
			this.HandlingStrategy = ReferenceHandlingStrategy.IgnoreCycles;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0002945F File Offset: 0x0002765F
		public override ReferenceResolver CreateResolver()
		{
			return new IgnoreReferenceResolver();
		}
	}
}
