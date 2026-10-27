using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200031E RID: 798
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EPoseDriverOffsetType")]
	public enum EPoseDriverOffsetType : byte
	{
		// Token: 0x0400131A RID: 4890
		Classic,
		// Token: 0x0400131B RID: 4891
		KuroCachedBone,
		// Token: 0x0400131C RID: 4892
		EPoseDriverOffsetType_MAX
	}
}
