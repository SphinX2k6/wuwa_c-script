using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002786 RID: 10118
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EAttributeTessellationDensityMode")]
	public enum EAttributeTessellationDensityMode : byte
	{
		// Token: 0x040149B4 RID: 84404
		RelativeArea,
		// Token: 0x040149B5 RID: 84405
		AbsoluteArea,
		// Token: 0x040149B6 RID: 84406
		RelativeLength,
		// Token: 0x040149B7 RID: 84407
		AbsoluteLength,
		// Token: 0x040149B8 RID: 84408
		UserDefined,
		// Token: 0x040149B9 RID: 84409
		OnScreenSize,
		// Token: 0x040149BA RID: 84410
		EAttributeTessellationDensityMode_MAX
	}
}
