using System;

namespace System.Text.Json
{
	// Token: 0x0200001B RID: 27
	internal sealed class JsonSnakeCaseUpperNamingPolicy : JsonSeparatorNamingPolicy
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0000667F File Offset: 0x0000487F
		public JsonSnakeCaseUpperNamingPolicy() : base(false, '_')
		{
		}
	}
}
