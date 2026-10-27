using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002198 RID: 8600
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIPolygonUVType")]
	public enum UIPolygonUVType : byte
	{
		// Token: 0x0401174C RID: 71500
		SpriteRect,
		// Token: 0x0401174D RID: 71501
		HeightCenter,
		// Token: 0x0401174E RID: 71502
		StretchSpriteHeight,
		// Token: 0x0401174F RID: 71503
		UIPolygonUVType_MAX
	}
}
