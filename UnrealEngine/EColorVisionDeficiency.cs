using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027F9 RID: 10233
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EColorVisionDeficiency")]
	public enum EColorVisionDeficiency : byte
	{
		// Token: 0x04014D5D RID: 85341
		NormalVision,
		// Token: 0x04014D5E RID: 85342
		Deuteranope,
		// Token: 0x04014D5F RID: 85343
		Protanope,
		// Token: 0x04014D60 RID: 85344
		Tritanope,
		// Token: 0x04014D61 RID: 85345
		EColorVisionDeficiency_MAX
	}
}
