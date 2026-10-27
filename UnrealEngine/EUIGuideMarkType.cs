using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002005 RID: 8197
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUIGuideMarkType")]
	public enum EUIGuideMarkType : byte
	{
		// Token: 0x04010C79 RID: 68729
		Parent,
		// Token: 0x04010C7A RID: 68730
		Route,
		// Token: 0x04010C7B RID: 68731
		Child,
		// Token: 0x04010C7C RID: 68732
		ChildWithoutRoute,
		// Token: 0x04010C7D RID: 68733
		EUIGuideMarkType_MAX
	}
}
