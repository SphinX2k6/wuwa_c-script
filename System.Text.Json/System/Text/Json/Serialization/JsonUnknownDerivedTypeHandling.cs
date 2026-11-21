using System;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000099 RID: 153
	public enum JsonUnknownDerivedTypeHandling
	{
		// Token: 0x04000299 RID: 665
		FailSerialization,
		// Token: 0x0400029A RID: 666
		FallBackToBaseType,
		// Token: 0x0400029B RID: 667
		FallBackToNearestAncestor
	}
}
