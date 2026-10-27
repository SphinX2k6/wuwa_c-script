using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002758 RID: 10072
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sharphereal.EKooSharpBuildConfiguration")]
	public enum EKooSharpBuildConfiguration : byte
	{
		// Token: 0x040147C9 RID: 83913
		Debug,
		// Token: 0x040147CA RID: 83914
		DebugEditor,
		// Token: 0x040147CB RID: 83915
		DebugGame,
		// Token: 0x040147CC RID: 83916
		DebugGameEditor,
		// Token: 0x040147CD RID: 83917
		Development,
		// Token: 0x040147CE RID: 83918
		DevelopmentEditor,
		// Token: 0x040147CF RID: 83919
		Test,
		// Token: 0x040147D0 RID: 83920
		Shipping,
		// Token: 0x040147D1 RID: 83921
		EKooSharpBuildConfiguration_MAX
	}
}
