using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000836 RID: 2102
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.AnimPhysCollisionType")]
	public enum AnimPhysCollisionType : byte
	{
		// Token: 0x04003649 RID: 13897
		CoM,
		// Token: 0x0400364A RID: 13898
		CustomSphere,
		// Token: 0x0400364B RID: 13899
		InnerSphere,
		// Token: 0x0400364C RID: 13900
		OuterSphere,
		// Token: 0x0400364D RID: 13901
		AnimPhysCollisionType_MAX
	}
}
