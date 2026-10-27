using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015EE RID: 5614
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EKuroSanityFlag")]
	public enum EKuroSanityFlag : byte
	{
		// Token: 0x0400B00C RID: 45068
		TextureMipEnabled,
		// Token: 0x0400B00D RID: 45069
		TexturePowerOfTwo,
		// Token: 0x0400B00E RID: 45070
		MeshCPUAccessDisabled,
		// Token: 0x0400B00F RID: 45071
		EKuroSanityFlag_MAX
	}
}
