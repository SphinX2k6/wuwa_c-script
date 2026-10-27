using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC5 RID: 2757
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialVectorCoordTransformSource")]
	public enum EMaterialVectorCoordTransformSource
	{
		// Token: 0x04004A5A RID: 19034
		TRANSFORMSOURCE_Tangent,
		// Token: 0x04004A5B RID: 19035
		TRANSFORMSOURCE_Local,
		// Token: 0x04004A5C RID: 19036
		TRANSFORMSOURCE_World,
		// Token: 0x04004A5D RID: 19037
		TRANSFORMSOURCE_View,
		// Token: 0x04004A5E RID: 19038
		TRANSFORMSOURCE_Camera,
		// Token: 0x04004A5F RID: 19039
		TRANSFORMSOURCE_ParticleWorld,
		// Token: 0x04004A60 RID: 19040
		TRANSFORMSOURCE_MAX
	}
}
