using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000467 RID: 1127
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Chaos.ESetMaskConditionType")]
	public enum ESetMaskConditionType
	{
		// Token: 0x04001C29 RID: 7209
		Field_Set_Always,
		// Token: 0x04001C2A RID: 7210
		Field_Set_IFF_NOT_Interior,
		// Token: 0x04001C2B RID: 7211
		Field_Set_IFF_NOT_Exterior,
		// Token: 0x04001C2C RID: 7212
		Field_MaskCondition_Max
	}
}
