using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC4 RID: 2756
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialVectorCoordTransform")]
	public enum EMaterialVectorCoordTransform
	{
		// Token: 0x04004A52 RID: 19026
		TRANSFORM_Tangent,
		// Token: 0x04004A53 RID: 19027
		TRANSFORM_Local,
		// Token: 0x04004A54 RID: 19028
		TRANSFORM_World,
		// Token: 0x04004A55 RID: 19029
		TRANSFORM_View,
		// Token: 0x04004A56 RID: 19030
		TRANSFORM_Camera,
		// Token: 0x04004A57 RID: 19031
		TRANSFORM_ParticleWorld,
		// Token: 0x04004A58 RID: 19032
		TRANSFORM_MAX
	}
}
