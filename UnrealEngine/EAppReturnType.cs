using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000FC RID: 252
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.EAppReturnType")]
	public enum EAppReturnType
	{
		// Token: 0x04000447 RID: 1095
		No,
		// Token: 0x04000448 RID: 1096
		Yes,
		// Token: 0x04000449 RID: 1097
		YesAll,
		// Token: 0x0400044A RID: 1098
		NoAll,
		// Token: 0x0400044B RID: 1099
		Cancel,
		// Token: 0x0400044C RID: 1100
		Ok,
		// Token: 0x0400044D RID: 1101
		Retry,
		// Token: 0x0400044E RID: 1102
		Continue,
		// Token: 0x0400044F RID: 1103
		EAppReturnType_MAX
	}
}
