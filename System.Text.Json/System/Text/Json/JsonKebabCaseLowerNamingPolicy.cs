using System;

namespace System.Text.Json
{
	// Token: 0x02000014 RID: 20
	internal sealed class JsonKebabCaseLowerNamingPolicy : JsonSeparatorNamingPolicy
	{
		// Token: 0x06000204 RID: 516 RVA: 0x000063AE File Offset: 0x000045AE
		public JsonKebabCaseLowerNamingPolicy() : base(true, '-')
		{
		}
	}
}
