using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001636 RID: 5686
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECharViewDirectionStateType")]
	public enum ECharViewDirectionStateType : byte
	{
		// Token: 0x0400B308 RID: 45832
		LockDirection,
		// Token: 0x0400B309 RID: 45833
		AimDirection,
		// Token: 0x0400B30A RID: 45834
		FaceDirection,
		// Token: 0x0400B30B RID: 45835
		LookAtDirection,
		// Token: 0x0400B30C RID: 45836
		CameraDirection,
		// Token: 0x0400B30D RID: 45837
		ECharViewDirectionStateType_MAX
	}
}
