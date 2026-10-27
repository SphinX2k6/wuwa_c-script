using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021C5 RID: 8645
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UISpriteType")]
	public enum UISpriteType : byte
	{
		// Token: 0x04011910 RID: 71952
		Normal,
		// Token: 0x04011911 RID: 71953
		Sliced,
		// Token: 0x04011912 RID: 71954
		SlicedFrame,
		// Token: 0x04011913 RID: 71955
		Tiled,
		// Token: 0x04011914 RID: 71956
		Filled,
		// Token: 0x04011915 RID: 71957
		FilledSliced,
		// Token: 0x04011916 RID: 71958
		FilledSlicedFrame,
		// Token: 0x04011917 RID: 71959
		SliceEx,
		// Token: 0x04011918 RID: 71960
		FillStartEnd,
		// Token: 0x04011919 RID: 71961
		FillStartEndEx,
		// Token: 0x0401191A RID: 71962
		UISpriteType_MAX
	}
}
