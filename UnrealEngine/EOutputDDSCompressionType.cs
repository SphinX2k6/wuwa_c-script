using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002795 RID: 10133
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EOutputDDSCompressionType")]
	public enum EOutputDDSCompressionType : byte
	{
		// Token: 0x04014A0E RID: 84494
		NoCompression = 255,
		// Token: 0x04014A0F RID: 84495
		BC1 = 0,
		// Token: 0x04014A10 RID: 84496
		BC2,
		// Token: 0x04014A11 RID: 84497
		BC3,
		// Token: 0x04014A12 RID: 84498
		BC4,
		// Token: 0x04014A13 RID: 84499
		BC5
	}
}
