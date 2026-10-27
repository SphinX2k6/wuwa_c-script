using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A19 RID: 2585
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBoneFoldMethod")]
	public enum EBoneFoldMethod : byte
	{
		// Token: 0x04004532 RID: 17714
		FoldEverything,
		// Token: 0x04004533 RID: 17715
		FoldBetweenNextFolder,
		// Token: 0x04004534 RID: 17716
		FoldByAutoLODCalc,
		// Token: 0x04004535 RID: 17717
		None,
		// Token: 0x04004536 RID: 17718
		EBoneFoldMethod_MAX
	}
}
