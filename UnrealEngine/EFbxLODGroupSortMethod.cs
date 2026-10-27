using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A1C RID: 10780
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFbxLODGroupSortMethod")]
	public enum EFbxLODGroupSortMethod : byte
	{
		// Token: 0x04015DEB RID: 89579
		SortByName,
		// Token: 0x04015DEC RID: 89580
		SortByDescendingAge,
		// Token: 0x04015DED RID: 89581
		EFbxLODGroupSortMethod_MAX
	}
}
