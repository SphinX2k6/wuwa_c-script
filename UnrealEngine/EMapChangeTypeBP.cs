using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001818 RID: 6168
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EMapChangeTypeBP")]
	public enum EMapChangeTypeBP : byte
	{
		// Token: 0x0400C602 RID: 50690
		LoadMap,
		// Token: 0x0400C603 RID: 50691
		SaveMap,
		// Token: 0x0400C604 RID: 50692
		NewMap,
		// Token: 0x0400C605 RID: 50693
		TearDownWorld,
		// Token: 0x0400C606 RID: 50694
		Unkown = 100,
		// Token: 0x0400C607 RID: 50695
		EMapChangeTypeBP_MAX
	}
}
