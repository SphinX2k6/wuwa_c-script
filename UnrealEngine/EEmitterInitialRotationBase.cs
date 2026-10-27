using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016D6 RID: 5846
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EEmitterInitialRotationBase")]
	public enum EEmitterInitialRotationBase : byte
	{
		// Token: 0x0400B845 RID: 47173
		OwnerForward,
		// Token: 0x0400B846 RID: 47174
		SocketRotation,
		// Token: 0x0400B847 RID: 47175
		SpawnToOwner,
		// Token: 0x0400B848 RID: 47176
		SpawnToSkillTarget,
		// Token: 0x0400B849 RID: 47177
		InheritParentEmitter,
		// Token: 0x0400B84A RID: 47178
		EEmitterInitialRotationBase_MAX
	}
}
