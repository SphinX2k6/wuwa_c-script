using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000340 RID: 832
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.EKuroSceneItemStopRotateMethod")]
	public enum EKuroSceneItemStopRotateMethod : byte
	{
		// Token: 0x0400232F RID: 9007
		KeepCurrent,
		// Token: 0x04002330 RID: 9008
		JumpToStart,
		// Token: 0x04002331 RID: 9009
		JumpToEnd,
		// Token: 0x04002332 RID: 9010
		EKuroSceneItemStopRotateMethod_MAX
	}
}
