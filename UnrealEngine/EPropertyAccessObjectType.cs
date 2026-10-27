using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002662 RID: 9826
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PropertyAccess.EPropertyAccessObjectType")]
	public enum EPropertyAccessObjectType : byte
	{
		// Token: 0x040139F0 RID: 80368
		None,
		// Token: 0x040139F1 RID: 80369
		Object,
		// Token: 0x040139F2 RID: 80370
		WeakObject,
		// Token: 0x040139F3 RID: 80371
		SoftObject,
		// Token: 0x040139F4 RID: 80372
		EPropertyAccessObjectType_MAX
	}
}
