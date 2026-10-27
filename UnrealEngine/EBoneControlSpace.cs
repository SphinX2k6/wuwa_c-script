using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A16 RID: 2582
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBoneControlSpace")]
	public enum EBoneControlSpace
	{
		// Token: 0x04004520 RID: 17696
		BCS_WorldSpace,
		// Token: 0x04004521 RID: 17697
		BCS_ComponentSpace,
		// Token: 0x04004522 RID: 17698
		BCS_ParentBoneSpace,
		// Token: 0x04004523 RID: 17699
		BCS_BoneSpace,
		// Token: 0x04004524 RID: 17700
		BCS_MAX
	}
}
