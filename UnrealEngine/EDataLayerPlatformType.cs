using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A3C RID: 2620
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EDataLayerPlatformType")]
	public enum EDataLayerPlatformType : byte
	{
		// Token: 0x04004617 RID: 17943
		None,
		// Token: 0x04004618 RID: 17944
		Desktop,
		// Token: 0x04004619 RID: 17945
		Mobile,
		// Token: 0x0400461A RID: 17946
		Mac,
		// Token: 0x0400461B RID: 17947
		EditorOnly,
		// Token: 0x0400461C RID: 17948
		EDataLayerPlatformType_MAX
	}
}
