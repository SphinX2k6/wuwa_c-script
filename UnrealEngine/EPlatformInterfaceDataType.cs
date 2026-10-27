using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B1C RID: 2844
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPlatformInterfaceDataType")]
	public enum EPlatformInterfaceDataType
	{
		// Token: 0x04004DDF RID: 19935
		PIDT_None,
		// Token: 0x04004DE0 RID: 19936
		PIDT_Int,
		// Token: 0x04004DE1 RID: 19937
		PIDT_Float,
		// Token: 0x04004DE2 RID: 19938
		PIDT_String,
		// Token: 0x04004DE3 RID: 19939
		PIDT_Object,
		// Token: 0x04004DE4 RID: 19940
		PIDT_Custom,
		// Token: 0x04004DE5 RID: 19941
		PIDT_MAX
	}
}
