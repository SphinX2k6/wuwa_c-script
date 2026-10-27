using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002796 RID: 10134
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EOutputImageFileFormat")]
	public enum EOutputImageFileFormat : byte
	{
		// Token: 0x04014A15 RID: 84501
		BMP,
		// Token: 0x04014A16 RID: 84502
		DDS,
		// Token: 0x04014A17 RID: 84503
		JPEG,
		// Token: 0x04014A18 RID: 84504
		PNG,
		// Token: 0x04014A19 RID: 84505
		TGA,
		// Token: 0x04014A1A RID: 84506
		TIFF,
		// Token: 0x04014A1B RID: 84507
		EXR = 8,
		// Token: 0x04014A1C RID: 84508
		EOutputImageFileFormat_MAX
	}
}
