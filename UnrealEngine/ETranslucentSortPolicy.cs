using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BA1 RID: 2977
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETranslucentSortPolicy")]
	public enum ETranslucentSortPolicy
	{
		// Token: 0x040051F6 RID: 20982
		SortByDistance,
		// Token: 0x040051F7 RID: 20983
		SortByProjectedZ,
		// Token: 0x040051F8 RID: 20984
		SortAlongAxis,
		// Token: 0x040051F9 RID: 20985
		ETranslucentSortPolicy_MAX
	}
}
