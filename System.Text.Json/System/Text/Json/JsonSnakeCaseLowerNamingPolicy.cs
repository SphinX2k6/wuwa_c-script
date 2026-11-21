using System;

namespace System.Text.Json
{
	// Token: 0x0200001A RID: 26
	internal sealed class JsonSnakeCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
	{
		// Token: 0x0600020B RID: 523 RVA: 0x00006674 File Offset: 0x00004874
		public JsonSnakeCaseLowerNamingPolicy() : base(true, '_')
		{
		}
	}
}
