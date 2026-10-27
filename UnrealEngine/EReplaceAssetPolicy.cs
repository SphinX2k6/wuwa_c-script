using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A50 RID: 10832
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/USDStageImporter.EReplaceAssetPolicy")]
	public enum EReplaceAssetPolicy : byte
	{
		// Token: 0x04015F15 RID: 89877
		Append,
		// Token: 0x04015F16 RID: 89878
		Replace,
		// Token: 0x04015F17 RID: 89879
		Ignore,
		// Token: 0x04015F18 RID: 89880
		EReplaceAssetPolicy_MAX
	}
}
