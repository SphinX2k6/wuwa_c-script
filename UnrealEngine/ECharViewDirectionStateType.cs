using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E5 RID: 741
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ECharViewDirectionStateType")]
	public enum ECharViewDirectionStateType : byte
	{
		// Token: 0x04002043 RID: 8259
		LockDirection,
		// Token: 0x04002044 RID: 8260
		AimDirection,
		// Token: 0x04002045 RID: 8261
		FaceDirection,
		// Token: 0x04002046 RID: 8262
		LookAtDirection,
		// Token: 0x04002047 RID: 8263
		CameraDirection,
		// Token: 0x04002048 RID: 8264
		ECharViewDirectionStateType_MAX
	}
}
