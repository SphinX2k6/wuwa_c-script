using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A9C RID: 10908
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/XeFGBlueprint.EXeFGMode")]
	public enum EXeFGMode : byte
	{
		// Token: 0x040160D1 RID: 90321
		Off,
		// Token: 0x040160D2 RID: 90322
		On,
		// Token: 0x040160D3 RID: 90323
		On2x,
		// Token: 0x040160D4 RID: 90324
		On3x,
		// Token: 0x040160D5 RID: 90325
		On4x,
		// Token: 0x040160D6 RID: 90326
		EXeFGMode_MAX
	}
}
