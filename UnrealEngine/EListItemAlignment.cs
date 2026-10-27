using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200284A RID: 10314
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EListItemAlignment")]
	public enum EListItemAlignment : byte
	{
		// Token: 0x04014FB1 RID: 85937
		EvenlyDistributed,
		// Token: 0x04014FB2 RID: 85938
		EvenlySize,
		// Token: 0x04014FB3 RID: 85939
		EvenlyWide,
		// Token: 0x04014FB4 RID: 85940
		LeftAligned,
		// Token: 0x04014FB5 RID: 85941
		RightAligned,
		// Token: 0x04014FB6 RID: 85942
		CenterAligned,
		// Token: 0x04014FB7 RID: 85943
		Fill,
		// Token: 0x04014FB8 RID: 85944
		EListItemAlignment_MAX
	}
}
