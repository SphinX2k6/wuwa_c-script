using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ABB RID: 2747
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialPositionTransformSource")]
	public enum EMaterialPositionTransformSource
	{
		// Token: 0x040049BC RID: 18876
		TRANSFORMPOSSOURCE_Local,
		// Token: 0x040049BD RID: 18877
		TRANSFORMPOSSOURCE_World,
		// Token: 0x040049BE RID: 18878
		TRANSFORMPOSSOURCE_TranslatedWorld,
		// Token: 0x040049BF RID: 18879
		TRANSFORMPOSSOURCE_View,
		// Token: 0x040049C0 RID: 18880
		TRANSFORMPOSSOURCE_Camera,
		// Token: 0x040049C1 RID: 18881
		TRANSFORMPOSSOURCE_Particle,
		// Token: 0x040049C2 RID: 18882
		TRANSFORMPOSSOURCE_MAX
	}
}
