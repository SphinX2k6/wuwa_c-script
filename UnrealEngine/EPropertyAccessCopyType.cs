using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002660 RID: 9824
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PropertyAccess.EPropertyAccessCopyType")]
	public enum EPropertyAccessCopyType : byte
	{
		// Token: 0x040139D6 RID: 80342
		None,
		// Token: 0x040139D7 RID: 80343
		Plain,
		// Token: 0x040139D8 RID: 80344
		Complex,
		// Token: 0x040139D9 RID: 80345
		Bool,
		// Token: 0x040139DA RID: 80346
		Struct,
		// Token: 0x040139DB RID: 80347
		Object,
		// Token: 0x040139DC RID: 80348
		Name,
		// Token: 0x040139DD RID: 80349
		Array,
		// Token: 0x040139DE RID: 80350
		PromoteBoolToByte,
		// Token: 0x040139DF RID: 80351
		PromoteBoolToInt32,
		// Token: 0x040139E0 RID: 80352
		PromoteBoolToInt64,
		// Token: 0x040139E1 RID: 80353
		PromoteBoolToFloat,
		// Token: 0x040139E2 RID: 80354
		PromoteByteToInt32,
		// Token: 0x040139E3 RID: 80355
		PromoteByteToInt64,
		// Token: 0x040139E4 RID: 80356
		PromoteByteToFloat,
		// Token: 0x040139E5 RID: 80357
		PromoteInt32ToInt64,
		// Token: 0x040139E6 RID: 80358
		PromoteInt32ToFloat,
		// Token: 0x040139E7 RID: 80359
		EPropertyAccessCopyType_MAX
	}
}
