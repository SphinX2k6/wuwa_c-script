using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A19 RID: 10777
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EFbxExportCompatibility")]
	public enum EFbxExportCompatibility : byte
	{
		// Token: 0x04015DD7 RID: 89559
		FBX_2011,
		// Token: 0x04015DD8 RID: 89560
		FBX_2012,
		// Token: 0x04015DD9 RID: 89561
		FBX_2013,
		// Token: 0x04015DDA RID: 89562
		FBX_2014,
		// Token: 0x04015DDB RID: 89563
		FBX_2016,
		// Token: 0x04015DDC RID: 89564
		FBX_2018,
		// Token: 0x04015DDD RID: 89565
		FBX_2019,
		// Token: 0x04015DDE RID: 89566
		FBX_2020,
		// Token: 0x04015DDF RID: 89567
		FBX_MAX
	}
}
