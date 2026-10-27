using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B71 RID: 2929
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESpeedTreeGeometryType")]
	public enum ESpeedTreeGeometryType
	{
		// Token: 0x040050B6 RID: 20662
		STG_Branch,
		// Token: 0x040050B7 RID: 20663
		STG_Frond,
		// Token: 0x040050B8 RID: 20664
		STG_Leaf,
		// Token: 0x040050B9 RID: 20665
		STG_FacingLeaf,
		// Token: 0x040050BA RID: 20666
		STG_Billboard,
		// Token: 0x040050BB RID: 20667
		STG_MAX
	}
}
