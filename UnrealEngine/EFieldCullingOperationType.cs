using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200045D RID: 1117
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.EFieldCullingOperationType")]
	public enum EFieldCullingOperationType
	{
		// Token: 0x04001BD7 RID: 7127
		Field_Culling_Inside,
		// Token: 0x04001BD8 RID: 7128
		Field_Culling_Outside,
		// Token: 0x04001BD9 RID: 7129
		Field_Culling_Operation_Max,
		// Token: 0x04001BDA RID: 7130
		Field_Culling_MAX
	}
}
