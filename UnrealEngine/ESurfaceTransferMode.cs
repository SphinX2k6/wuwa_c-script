using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027A5 RID: 10149
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ESurfaceTransferMode")]
	public enum ESurfaceTransferMode : byte
	{
		// Token: 0x04014A63 RID: 84579
		Fast,
		// Token: 0x04014A64 RID: 84580
		Accurate,
		// Token: 0x04014A65 RID: 84581
		ESurfaceTransferMode_MAX
	}
}
