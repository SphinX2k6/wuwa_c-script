using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B9D RID: 2973
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ETransitionLogicType")]
	public enum ETransitionLogicType
	{
		// Token: 0x040051DC RID: 20956
		TLT_StandardBlend,
		// Token: 0x040051DD RID: 20957
		TLT_Inertialization,
		// Token: 0x040051DE RID: 20958
		TLT_Custom,
		// Token: 0x040051DF RID: 20959
		TLT_MAX
	}
}
