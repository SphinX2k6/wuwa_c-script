using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200217F RID: 8575
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIItemType")]
	public enum UIItemType : byte
	{
		// Token: 0x04011664 RID: 71268
		None,
		// Token: 0x04011665 RID: 71269
		UIItem,
		// Token: 0x04011666 RID: 71270
		UIBatchGeometryRenderable,
		// Token: 0x04011667 RID: 71271
		UIItemType_MAX
	}
}
