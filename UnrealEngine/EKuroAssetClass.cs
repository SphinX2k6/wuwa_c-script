using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015EC RID: 5612
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroActorFolderCheck.EKuroAssetClass")]
	public enum EKuroAssetClass : byte
	{
		// Token: 0x0400B001 RID: 45057
		Any,
		// Token: 0x0400B002 RID: 45058
		Texture,
		// Token: 0x0400B003 RID: 45059
		StaticMesh,
		// Token: 0x0400B004 RID: 45060
		SkeletalMesh,
		// Token: 0x0400B005 RID: 45061
		Anim,
		// Token: 0x0400B006 RID: 45062
		EKuroAssetClass_MAX
	}
}
