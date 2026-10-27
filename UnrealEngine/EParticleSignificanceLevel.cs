using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B0F RID: 2831
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSignificanceLevel")]
	public enum EParticleSignificanceLevel : byte
	{
		// Token: 0x04004D8C RID: 19852
		Low,
		// Token: 0x04004D8D RID: 19853
		Medium,
		// Token: 0x04004D8E RID: 19854
		High,
		// Token: 0x04004D8F RID: 19855
		Critical,
		// Token: 0x04004D90 RID: 19856
		Num,
		// Token: 0x04004D91 RID: 19857
		EParticleSignificanceLevel_MAX
	}
}
