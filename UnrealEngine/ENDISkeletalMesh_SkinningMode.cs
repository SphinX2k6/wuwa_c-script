using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024DE RID: 9438
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENDISkeletalMesh_SkinningMode")]
	public enum ENDISkeletalMesh_SkinningMode : byte
	{
		// Token: 0x04012DA4 RID: 77220
		Invalid = 255,
		// Token: 0x04012DA5 RID: 77221
		None = 0,
		// Token: 0x04012DA6 RID: 77222
		SkinOnTheFly,
		// Token: 0x04012DA7 RID: 77223
		PreSkin
	}
}
