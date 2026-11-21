using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000659 RID: 1625
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUIGuideMarkType")]
	public enum EUIGuideMarkType : byte
	{
		// Token: 0x04003E19 RID: 15897
		Parent,
		// Token: 0x04003E1A RID: 15898
		Route,
		// Token: 0x04003E1B RID: 15899
		Child,
		// Token: 0x04003E1C RID: 15900
		ChildWithoutRoute,
		// Token: 0x04003E1D RID: 15901
		EUIGuideMarkType_MAX
	}
}
