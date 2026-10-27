using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001817 RID: 6167
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.EFontType")]
	public enum EFontType : byte
	{
		// Token: 0x0400C5FB RID: 50683
		Tiny,
		// Token: 0x0400C5FC RID: 50684
		Small,
		// Token: 0x0400C5FD RID: 50685
		Medium,
		// Token: 0x0400C5FE RID: 50686
		Large,
		// Token: 0x0400C5FF RID: 50687
		Max,
		// Token: 0x0400C600 RID: 50688
		EFontType_MAX
	}
}
