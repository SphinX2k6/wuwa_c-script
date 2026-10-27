using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A38 RID: 2616
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ECustomBoneAttributeLookup")]
	public enum ECustomBoneAttributeLookup : byte
	{
		// Token: 0x04004600 RID: 17920
		BoneOnly,
		// Token: 0x04004601 RID: 17921
		ImmediateParent,
		// Token: 0x04004602 RID: 17922
		ParentHierarchy,
		// Token: 0x04004603 RID: 17923
		ECustomBoneAttributeLookup_MAX
	}
}
