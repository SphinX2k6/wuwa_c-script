using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001751 RID: 5969
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.EKuroSceneItemStopRotateMethod")]
	public enum EKuroSceneItemStopRotateMethod : byte
	{
		// Token: 0x0400BB3E RID: 47934
		KeepCurrent,
		// Token: 0x0400BB3F RID: 47935
		JumpToStart,
		// Token: 0x0400BB40 RID: 47936
		JumpToEnd,
		// Token: 0x0400BB41 RID: 47937
		EKuroSceneItemStopRotateMethod_MAX
	}
}
