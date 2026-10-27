using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002661 RID: 9825
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PropertyAccess.EPropertyAccessIndirectionType")]
	public enum EPropertyAccessIndirectionType : byte
	{
		// Token: 0x040139E9 RID: 80361
		Offset,
		// Token: 0x040139EA RID: 80362
		Object,
		// Token: 0x040139EB RID: 80363
		Array,
		// Token: 0x040139EC RID: 80364
		ScriptFunction,
		// Token: 0x040139ED RID: 80365
		NativeFunction,
		// Token: 0x040139EE RID: 80366
		EPropertyAccessIndirectionType_MAX
	}
}
