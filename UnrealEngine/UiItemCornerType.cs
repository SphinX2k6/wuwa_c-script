using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200217C RID: 8572
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UiItemCornerType")]
	public enum UiItemCornerType : byte
	{
		// Token: 0x04011657 RID: 71255
		BottomLeft,
		// Token: 0x04011658 RID: 71256
		TopLeft,
		// Token: 0x04011659 RID: 71257
		TopRight,
		// Token: 0x0401165A RID: 71258
		BottomRight,
		// Token: 0x0401165B RID: 71259
		UiItemCornerType_MAX
	}
}
